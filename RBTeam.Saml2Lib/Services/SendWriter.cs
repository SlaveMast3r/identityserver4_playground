using System;
using System.Text;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Model;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x0200001B RID: 27
	internal class SendWriter : MessageProcessingService
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00005580 File Offset: 0x00003780
		internal override void ValidateModel(Saml2MessageModel model)
		{
			MissingModelDataException.Check(model.Info, "model.Info");
			MissingModelDataException.Check(model.Info.Binding, "model.Info.Binding");
			MissingModelDataException.Check(model.Message, "model.Message");
			MissingModelDataException.Check(model.Message.Destination, "model.Message.Destination");
			MissingModelDataException.Check(model.MessageRaw, "model.MessageRaw");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000055E8 File Offset: 0x000037E8
		internal override void Process(Saml2MessageModel model)
		{
			string binding = model.Info.Binding;
			if (binding == "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST")
			{
				SendWriter.WritePostMessage(model.Config.HttpContext, model.Message.Destination, model.MessageRaw, model.Config.PostBindingHtml, model.Info.IsResponse);
				return;
			}
			if (!(binding == "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"))
			{
				throw new Saml2ModuleException("Binding not supported: " + model.Info.Binding);
			}
			SendWriter.WriteRedirectMessage(model.Config.HttpContext, model.Message.Destination, model.MessageRaw, model.UrlSignature, model.Info.IsResponse);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000056A4 File Offset: 0x000038A4
		private static void WritePostMessage(IHttpContext httpContext, string destination, string messageRaw, string postBindingHtml, bool isResponse)
		{
			string saml2ParameterName = BindingUtility.GetSaml2ParameterName(isResponse);
			string newValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(messageRaw));
			postBindingHtml = postBindingHtml.Replace("{samlDestination}", destination);
			postBindingHtml = postBindingHtml.Replace("{samlMessageType}", saml2ParameterName);
			postBindingHtml = postBindingHtml.Replace("{samlMessage}", newValue);
			httpContext.ResponseWrite(postBindingHtml);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000056FC File Offset: 0x000038FC
		private static void WriteRedirectMessage(IHttpContext httpContext, string destination, string messageRaw, byte[] urlSignature, bool isResponse)
		{
			string url;
			if (urlSignature == null)
			{
				url = destination + "?" + BindingUtility.GetRedirectQueryString(httpContext, messageRaw, isResponse);
			}
			else
			{
				url = string.Concat(new string[]
				{
					destination,
					"?",
					BindingUtility.GetRedirectQueryStringWithSignAlg(httpContext, messageRaw, isResponse),
					"&Signature=",
					httpContext.ApplicationUrlEncode(Convert.ToBase64String(urlSignature))
				});
			}
			httpContext.ResponseRedirect(url);
		}
	}
}
