using System;
using System.Linq;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x0200000F RID: 15
	internal class MetadataValidator
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000032D0 File Offset: 0x000014D0
		internal static void Check(EntityDescriptorType entity, bool shouldBeSp)
		{
			string text = shouldBeSp ? "service provider" : "identity provider";
			ConfigException.Check(entity, text + " metadata not provided");
			ConfigException.Check(entity.Entity, text + " metadata empty");
			string str = string.Concat(new string[]
			{
				Environment.NewLine,
				text,
				" ",
				entity.entityID,
				" metadata:",
				Environment.NewLine
			});
			if ((shouldBeSp && !entity.IsSP) || (!shouldBeSp && !entity.IsIDP))
			{
				ConfigException.Check(null, str + "entity is not " + text);
			}
			ConfigException.Check(entity.entityID, str + "entityID");
			ConfigException.Check(entity.Entity.KeyDescriptor, str + "KeyDescriptor");
			KeyDescriptorType keyDescriptorType = entity.Entity.KeyDescriptor.FirstOrDefault((KeyDescriptorType keyDesc) => keyDesc.use == KeyTypes.signing);
			KeyDescriptorType keyDescriptorType2 = entity.Entity.KeyDescriptor.FirstOrDefault((KeyDescriptorType keyDesc) => keyDesc.use == KeyTypes.encryption);
			ConfigException.Check(keyDescriptorType, str + "KeyDescriptor[use = signing]");
			ConfigException.Check(keyDescriptorType2, str + "KeyDescriptor[use = encryption]");
			if (keyDescriptorType != null)
			{
				ConfigException.Check(keyDescriptorType.KeyInfo, str + "KeyDescriptor[use = signing] / KeyInfo");
				ConfigException.Check(keyDescriptorType.KeyInfo.Items, str + "KeyDescriptor[use = signing] / KeyInfo / X509Data");
				X509DataType x509DataType = keyDescriptorType.KeyInfo.Items[0] as X509DataType;
				ConfigException.Check(x509DataType, str + "KeyDescriptor[use = signing] / KeyInfo / X509Data");
				if (x509DataType != null)
				{
					ConfigException.Check(x509DataType.Items, str + "KeyDescriptor[use = signing] / KeyInfo / X509Data / X509Certificate");
					ConfigException.Check(x509DataType.Items[0] as byte[], str + "KeyDescriptor[use = signing] / KeyInfo / X509Data / X509Certificate");
				}
			}
			if (keyDescriptorType2 == null)
			{
				return;
			}
			ConfigException.Check(keyDescriptorType2.KeyInfo, str + "KeyDescriptor[use = encryption] / KeyInfo");
			ConfigException.Check(keyDescriptorType2.KeyInfo.Items, str + "KeyDescriptor[use = encryption] / KeyInfo / X509Data");
			X509DataType x509DataType2 = keyDescriptorType2.KeyInfo.Items[0] as X509DataType;
			ConfigException.Check(x509DataType2, str + "KeyDescriptor[use = encryption] / KeyInfo / X509Data");
			if (x509DataType2 == null)
			{
				return;
			}
			ConfigException.Check(x509DataType2.Items, str + "KeyDescriptor[use = encryption] / KeyInfo / X509Data / X509Certificate");
			ConfigException.Check(x509DataType2.Items[0] as byte[], str + "KeyDescriptor[use = encryption] / KeyInfo / X509Data / X509Certificate");
		}
	}
}
