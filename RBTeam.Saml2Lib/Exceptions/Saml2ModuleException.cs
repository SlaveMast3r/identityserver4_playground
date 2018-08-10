using System;

namespace RBTeam.Saml2Lib.Exceptions
{
	// Token: 0x02000028 RID: 40
	public class Saml2ModuleException : Exception
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00006050 File Offset: 0x00004250
		internal Saml2ModuleException(string message) : base(message)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006084 File Offset: 0x00004284
		internal Saml2ModuleException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
