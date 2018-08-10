using System;
using System.Collections.Generic;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Model;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x0200001C RID: 28
	internal class UserDataSessionStore : UserDataStoreBase
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00005768 File Offset: 0x00003968
		protected internal override void StoreCache(Dictionary<string, UserData> cache, Saml2Config config)
		{
			string value = config.GlobalContext.Serializer.Serialize(cache);
			config.HttpContext.SessionSet("Saml2Handler.UserDataSessionStore", value);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005798 File Offset: 0x00003998
		protected internal override Dictionary<string, UserData> LoadCache(Saml2Config config)
		{
			string text = (string)config.HttpContext.SessionGet("Saml2Handler.UserDataSessionStore");
			if (text == null)
			{
				return new Dictionary<string, UserData>();
			}
			return config.GlobalContext.Serializer.Deserialize<Dictionary<string, UserData>>(text);
		}
	}
}
