using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x02000009 RID: 9
	internal static class CertificateUtility
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002B88 File Offset: 0x00000D88
		internal static X509Certificate2 GetMetadataCertificate(Saml2Config config, EntityDescriptorType entity, KeyTypes keyType, bool privateKey)
		{
			X509Certificate2 x509Certificate;
			try
			{
				x509Certificate = new X509Certificate2(CertificateUtility.GetMetadataCertificateBytes(entity, KeyTypes.signing));
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException(string.Concat(new object[]
				{
					"Unable to parse ",
					keyType,
					" certificate from metatada ",
					entity.entityID
				}), innerException);
			}
			if (privateKey)
			{
				return CertificateUtility.FindCert(config.CertificateStore.StoreLocationEnum, config.CertificateStore.StoreNameEnum, config.CertificateStore.FindTypeEnum, x509Certificate.GetCertHashString());
			}
			return x509Certificate;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002C1C File Offset: 0x00000E1C
		internal static byte[] GetMetadataCertificateBytes(EntityDescriptorType entity, KeyTypes keyType)
		{
			byte[] result;
			try
			{
				X509DataType x509DataType = ((SSODescriptorType)entity.Items[0]).KeyDescriptor.First((KeyDescriptorType keyDesc) => keyDesc.useSpecified && keyDesc.use == keyType).KeyInfo.Items[0] as X509DataType;
				result = (((x509DataType != null) ? x509DataType.Items[0] : null) as byte[]);
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException(string.Concat(new object[]
				{
					"cannot read ",
					keyType,
					" certificate content from metadata ",
					entity.entityID
				}), innerException);
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002CCC File Offset: 0x00000ECC
		internal static X509Certificate2 FindCert(StoreLocation location, StoreName storeName, X509FindType findType, string findValue)
		{
			X509Store x509Store = new X509Store(storeName, location);
			x509Store.Open(OpenFlags.ReadOnly);
			X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates.Find(findType, findValue, false);
			x509Store.Close();
			if (x509Certificate2Collection.Count == 0)
			{
				throw new Saml2ModuleException(string.Concat(new object[]
				{
					"certificate '",
					findValue,
					"' not found in store: ",
					location,
					", ",
					storeName,
					", ",
					findType
				}));
			}
			if (x509Certificate2Collection.Count > 1)
			{
				throw new Saml2ModuleException(string.Concat(new object[]
				{
					"multiple certificates matching '",
					findValue,
					"' were found in store: ",
					location,
					", ",
					storeName,
					", ",
					findType
				}));
			}
			return x509Certificate2Collection[0];
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002DB8 File Offset: 0x00000FB8
		internal static bool ValidateCertificate(X509Certificate2 cert)
		{
			bool result;
			try
			{
				result = new X509Chain(true)
				{
					ChainPolicy = 
					{
						RevocationMode = X509RevocationMode.NoCheck,
						RevocationFlag = X509RevocationFlag.EndCertificateOnly
					}
				}.Build(cert);
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("certificate validation error for cert: subject " + cert.Subject + ", thumb " + cert.GetCertHashString(), innerException);
			}
			return result;
		}
	}
}
