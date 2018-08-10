using System;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000B3 RID: 179
	public interface ISerializer
	{
		// Token: 0x060004F2 RID: 1266
		string Serialize(object obj);

		// Token: 0x060004F3 RID: 1267
		T Deserialize<T>(string str);
	}
}
