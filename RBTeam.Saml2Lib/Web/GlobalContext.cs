using System;
using RBTeam.Saml2Lib.Data.Infra;

namespace RBTeam.Saml2Lib.Web
{
	// Token: 0x02000004 RID: 4
	public class GlobalContext : IGlobalContext
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000282B File Offset: 0x00000A2B
		public DateTime DateTimeNow
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002832 File Offset: 0x00000A32
		public Guid NewGuid
		{
			get
			{
				return Guid.NewGuid();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000283C File Offset: 0x00000A3C
		public ISerializer Serializer
		{
			get
			{
				Serializer result;
				if ((result = this.serializer) == null)
				{
					result = (this.serializer = new Serializer());
				}
				return result;
			}
		}

		// Token: 0x0400000C RID: 12
		private Serializer serializer;
	}
}
