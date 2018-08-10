using System;
using System.Web.Script.Serialization;
using RBTeam.Saml2Lib.Data.Infra;

namespace RBTeam.Saml2Lib.Web
{
	// Token: 0x02000006 RID: 6
	internal class Serializer : ISerializer
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002A8A File Offset: 0x00000C8A
		public Serializer()
		{
			this.serializer = new JavaScriptSerializer();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002A9D File Offset: 0x00000C9D
		public string Serialize(object obj)
		{
			return this.serializer.Serialize(obj);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002AAB File Offset: 0x00000CAB
		public T Deserialize<T>(string str)
		{
			return this.serializer.Deserialize<T>(str);
		}

		// Token: 0x0400000E RID: 14
		private readonly JavaScriptSerializer serializer;
	}
}
