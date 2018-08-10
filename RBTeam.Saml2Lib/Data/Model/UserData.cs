using System;
using System.Collections.Generic;

namespace RBTeam.Saml2Lib.Data.Model
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public class UserData
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00002823 File Offset: 0x00000A23
		public UserData()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000064CC File Offset: 0x000046CC
		internal UserData(object value)
		{
			this.expires = false;
			Dictionary<string, UserData> dictionary = value as Dictionary<string, UserData>;
			if (dictionary != null)
			{
				this.dict = dictionary;
				return;
			}
			this.data = value;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000064FF File Offset: 0x000046FF
		internal UserData(object value, DateTime creationTime) : this(value)
		{
			this.creationTime = creationTime;
			this.expires = true;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00006516 File Offset: 0x00004716
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000651E File Offset: 0x0000471E
		public DateTime Creation
		{
			get
			{
				return this.creationTime;
			}
			set
			{
				this.creationTime = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00006527 File Offset: 0x00004727
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000652F File Offset: 0x0000472F
		public bool Expires
		{
			get
			{
				return this.expires;
			}
			set
			{
				this.expires = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00006538 File Offset: 0x00004738
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00006540 File Offset: 0x00004740
		public object Data
		{
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006549 File Offset: 0x00004749
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00006551 File Offset: 0x00004751
		public Dictionary<string, UserData> Dict
		{
			get
			{
				return this.dict;
			}
			set
			{
				this.dict = value;
			}
		}

		// Token: 0x04000052 RID: 82
		private DateTime creationTime;

		// Token: 0x04000053 RID: 83
		private bool expires;

		// Token: 0x04000054 RID: 84
		private object data;

		// Token: 0x04000055 RID: 85
		private Dictionary<string, UserData> dict;
	}
}
