using System;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x0200000D RID: 13
	internal static class MessageUtility
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002FA4 File Offset: 0x000011A4
		internal static string DateToString(DateTime date)
		{
			if (date.Kind == DateTimeKind.Local)
			{
				date = date.ToUniversalTime();
			}
			return date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002FC8 File Offset: 0x000011C8
		internal static DateTime DateFromString(string str)
		{
			DateTime result;
			try
			{
				result = DateTime.Parse(str);
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("Unable to parse DateTime: '" + str + "'", innerException);
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003008 File Offset: 0x00001208
		internal static string GetResponseStatus(ISaml2ResponseMessage message)
		{
			StatusResponseType statusResponseType = message as StatusResponseType;
			if (statusResponseType == null)
			{
				return null;
			}
			StatusType status = statusResponseType.Status;
			if (status == null)
			{
				return null;
			}
			StatusCodeType statusCode = status.StatusCode;
			if (statusCode == null)
			{
				return null;
			}
			return statusCode.Value;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003031 File Offset: 0x00001231
		internal static string GetSecondLevelResponseStatus(ISaml2ResponseMessage message)
		{
			StatusResponseType statusResponseType = message as StatusResponseType;
			if (statusResponseType == null)
			{
				return null;
			}
			StatusType status = statusResponseType.Status;
			if (status == null)
			{
				return null;
			}
			StatusCodeType statusCode = status.StatusCode;
			if (statusCode == null)
			{
				return null;
			}
			StatusCodeType statusCode2 = statusCode.StatusCode;
			if (statusCode2 == null)
			{
				return null;
			}
			return statusCode2.Value;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003068 File Offset: 0x00001268
		internal static void SetResponseStatus(ISaml2ResponseMessage message, string statusCode)
		{
			StatusResponseType statusResponseType = message as StatusResponseType;
			if (statusResponseType == null)
			{
				return;
			}
			if (statusResponseType.Status == null)
			{
				statusResponseType.Status = new StatusType();
			}
			if (statusResponseType.Status.StatusCode == null)
			{
				statusResponseType.Status.StatusCode = new StatusCodeType();
			}
			statusResponseType.Status.StatusCode.Value = statusCode;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000030C4 File Offset: 0x000012C4
		internal static void SetSecondLevelResponseStatus(ISaml2ResponseMessage message, string statusCode)
		{
			StatusResponseType statusResponseType = message as StatusResponseType;
			if (statusResponseType == null)
			{
				return;
			}
			StatusType status = statusResponseType.Status;
			if (((status != null) ? status.StatusCode : null) == null)
			{
				MessageUtility.SetResponseStatus(message, "");
			}
			if (statusResponseType.Status.StatusCode.StatusCode == null)
			{
				statusResponseType.Status.StatusCode.StatusCode = new StatusCodeType();
			}
			statusResponseType.Status.StatusCode.StatusCode.Value = statusCode;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003138 File Offset: 0x00001338
		internal static bool HasNoPassiveStatusCode(ISaml2ResponseMessage message)
		{
			return message.StatusCode == "urn:oasis:names:tc:SAML:2.0:status:Requester" && message.SecondLevelStatusCode == "urn:oasis:names:tc:SAML:2.0:status:NoPassive";
		}
	}
}
