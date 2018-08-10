using System;
using System.Collections.Generic;
using System.Linq;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x0200000E RID: 14
	internal static class MetadataUtility
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0000315E File Offset: 0x0000135E
		internal static string GetReceiverDestinationByServiceType(EntityDescriptorType receiver, Saml2ServiceTypeEnum serviceType, string binding, bool isResponse)
		{
			EndpointType[] receiverEndpointsByServiceType = MetadataUtility.GetReceiverEndpointsByServiceType(receiver, serviceType);
			if (receiverEndpointsByServiceType == null)
			{
				MetadataUtility.ThrowUsupportedServiceError(receiver.entityID, serviceType, binding);
			}
			IList<string> endpointDestinationsByBinding = MetadataUtility.GetEndpointDestinationsByBinding(receiverEndpointsByServiceType, binding, isResponse);
			if (endpointDestinationsByBinding.Count == 0)
			{
				MetadataUtility.ThrowUsupportedServiceError(receiver.entityID, serviceType, binding);
			}
			return endpointDestinationsByBinding[0];
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000319C File Offset: 0x0000139C
		internal static EndpointType[] GetReceiverEndpointsByServiceType(EntityDescriptorType receiver, Saml2ServiceTypeEnum serviceType)
		{
			IDPSSODescriptorType idpssodescriptorType = receiver.Entity as IDPSSODescriptorType;
			SPSSODescriptorType spssodescriptorType = receiver.Entity as SPSSODescriptorType;
			SSODescriptorType entity = receiver.Entity;
			EndpointType[] result;
			switch (serviceType)
			{
			case Saml2ServiceTypeEnum.SingleSignOnService:
				result = ((idpssodescriptorType != null) ? idpssodescriptorType.SingleSignOnService : null);
				break;
			case Saml2ServiceTypeEnum.SingleLogoutService:
				result = ((entity != null) ? entity.SingleLogoutService : null);
				break;
			case Saml2ServiceTypeEnum.AssertionConsumerService:
				result = ((spssodescriptorType != null) ? spssodescriptorType.AssertionConsumerService : null);
				break;
			default:
				throw new Saml2ModuleException("saml2 service type not supported: " + serviceType);
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003220 File Offset: 0x00001420
		internal static IList<string> GetEndpointDestinationsByBinding(EndpointType[] endpoints, string binding, bool isResponse)
		{
			List<string> list = new List<string>();
			if (endpoints != null && endpoints.Length != 0)
			{
				list.AddRange((from endpoint in endpoints
				where endpoint.Binding == binding
				select endpoint).Select(delegate(EndpointType endpoint)
				{
					if (!isResponse || string.IsNullOrEmpty(endpoint.ResponseLocation))
					{
						return endpoint.Location;
					}
					return endpoint.ResponseLocation;
				}));
			}
			return list;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003278 File Offset: 0x00001478
		internal static void ThrowUsupportedServiceError(string entityId, Saml2ServiceTypeEnum serviceType, string binding)
		{
			throw new Saml2ModuleException(string.Concat(new object[]
			{
				"check ",
				entityId,
				" metadata:",
				Environment.NewLine,
				"service ",
				serviceType,
				" is not supported with binding ",
				binding
			}));
		}
	}
}
