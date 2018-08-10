using System;

namespace RBTeam.Saml2Lib.Exceptions
{
	// Token: 0x02000027 RID: 39
	public class SignOutException : Exception
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00006050 File Offset: 0x00004250
		internal SignOutException(string message) : base(message)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006084 File Offset: 0x00004284
		internal SignOutException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
