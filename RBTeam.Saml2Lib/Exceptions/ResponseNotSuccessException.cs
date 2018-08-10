using System;

namespace RBTeam.Saml2Lib.Exceptions
{
	// Token: 0x02000025 RID: 37
	public class ResponseNotSuccessException : Exception
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00006050 File Offset: 0x00004250
		internal ResponseNotSuccessException(string message) : base(message)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006084 File Offset: 0x00004284
		internal ResponseNotSuccessException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
