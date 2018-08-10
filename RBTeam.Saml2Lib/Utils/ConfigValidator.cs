using System;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x0200000A RID: 10
	internal class ConfigValidator
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002E20 File Offset: 0x00001020
		internal static void Check(Saml2Config config)
		{
			ConfigException.Check(config, "config");
			ConfigException.Check(config.GlobalContext, "config.GlobalContext");
			ConfigException.Check(config.GlobalContext.Serializer, "config.GlobalContext.Serializer");
			ConfigException.Check(config.HttpContext, "config.HttpContext");
			if (string.IsNullOrEmpty(config.PostBindingHtmlFile))
			{
				return;
			}
			if (!config.PostBindingHtml.Contains("{samlDestination}") || !config.PostBindingHtml.Contains("{samlMessageType}") || !config.PostBindingHtml.Contains("{samlMessage}"))
			{
				ConfigException.Check(null, config.PostBindingHtmlFile + " must contain strings '{samlDestination}', '{samlMessageType}' and '{samlMessage}");
			}
		}
	}
}
