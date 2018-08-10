using System;

namespace RBTeam.Saml2Lib.Exceptions
{
	// Token: 0x02000026 RID: 38
	public class Saml2ModuleUnhandledException : Exception
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00006050 File Offset: 0x00004250
		internal Saml2ModuleUnhandledException(string message) : base(message)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00006084 File Offset: 0x00004284
		internal Saml2ModuleUnhandledException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
