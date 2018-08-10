using System;

namespace RBTeam.Saml2Lib.Events
{
	// Token: 0x02000029 RID: 41
	public class Saml2ErrorEventArgs : EventArgs
	{
		// Token: 0x060000EE RID: 238 RVA: 0x0000608E File Offset: 0x0000428E
		internal Saml2ErrorEventArgs(Exception exception)
		{
			if (exception == null)
			{
				throw new NullReferenceException("exception");
			}
			this.Exception = exception;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000060AB File Offset: 0x000042AB
		public Exception Exception { get; }
	}
}
