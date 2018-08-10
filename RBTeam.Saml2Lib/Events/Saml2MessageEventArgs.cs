using System;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Events
{
	// Token: 0x0200002C RID: 44
	public class Saml2MessageEventArgs : EventArgs
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x000060B3 File Offset: 0x000042B3
		internal Saml2MessageEventArgs(ISaml2Message message)
		{
			if (message == null)
			{
				throw new Saml2ModuleException("message");
			}
			this.Message = message;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000060D0 File Offset: 0x000042D0
		public ISaml2Message Message { get; }
	}
}
