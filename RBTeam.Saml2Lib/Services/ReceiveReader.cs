using System;
using System.Text;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x02000015 RID: 21
	internal class ReceiveReader : MessageProcessingService
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000242C File Offset: 0x0000062C
		internal override void ValidateModel(Saml2MessageModel model)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003E60 File Offset: 0x00002060
		internal override void Process(Saml2MessageModel model)
		{
			string requestHttpMethod = model.Config.HttpContext.RequestHttpMethod;
			string requestUrlAbsoluteUri = model.Config.HttpContext.RequestUrlAbsoluteUri;
			model.Info = new Saml2MessageInfo
			{
				ReceivedDestination = requestUrlAbsoluteUri
			};
			bool receivedIsResponse;
			if (!(requestHttpMethod == "POST"))
			{
				if (!(requestHttpMethod == "GET"))
				{
					throw new Saml2ModuleException("Http method not supported: " + requestHttpMethod);
				}
				model.Info.Binding = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect";
				model.MessageRaw = ReceiveReader.ReadRedirectMessage(model.Config.HttpContext, out model.UrlSignature, out receivedIsResponse);
			}
			else
			{
				model.Info.Binding = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST";
				model.MessageRaw = this.ReadPostMessage(model.Config.HttpContext, out receivedIsResponse);
			}
			model.Info.ReceivedIsResponse = receivedIsResponse;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003F38 File Offset: 0x00002138
		private string ReadPostMessage(IHttpContext httpContext, out bool isResponse)
		{
			isResponse = false;
			string text = httpContext.RequestPostParams["SAMLRequest"];
			if (text == null)
			{
				text = httpContext.RequestPostParams["SAMLResponse"];
				isResponse = true;
			}
			if (text == null)
			{
				throw new Saml2ModuleException("Saml POST binding: no SAML2 parameter in post request");
			}
			string @string;
			try
			{
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(text));
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("Saml POST binding: value of SAML2 parameter in post request cannot be decoded: " + text, innerException);
			}
			return @string;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003FB8 File Offset: 0x000021B8
		private static string ReadRedirectMessage(IHttpContext httpContext, out byte[] urlSignature, out bool isResponse)
		{
			isResponse = false;
			urlSignature = null;
			string requestUrlAbsoluteUri = httpContext.RequestUrlAbsoluteUri;
			string text = null;
			try
			{
				foreach (string text2 in new Uri(requestUrlAbsoluteUri).Query.Substring(1).Split(new char[]
				{
					'&'
				}))
				{
					if (text2.StartsWith("SAMLRequest=") || text2.StartsWith("SAMLResponse="))
					{
						if (text2.StartsWith("SAMLResponse="))
						{
							isResponse = true;
						}
						string[] array2 = text2.Split(new char[]
						{
							'='
						});
						text = DeflateUtility.UnZip(Convert.FromBase64String(httpContext.ApplicationUrlDecode(array2[1])));
					}
					if (text2.StartsWith("Signature="))
					{
						string[] array3 = text2.Split(new char[]
						{
							'='
						});
						urlSignature = Convert.FromBase64String(httpContext.ApplicationUrlDecode(array3[1]));
					}
				}
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("Saml Redirect binding: request url malformed: " + requestUrlAbsoluteUri, innerException);
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new Saml2ModuleException("Saml Redirect binding: no SAML2 parameter in url: " + requestUrlAbsoluteUri);
			}
			return text;
		}
	}
}
