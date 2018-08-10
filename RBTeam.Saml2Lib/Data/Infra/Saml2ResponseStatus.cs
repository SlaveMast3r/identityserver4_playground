using System;

namespace RBTeam.Saml2Lib.Data.Infra
{
	// Token: 0x020000B6 RID: 182
	public class Saml2ResponseStatus
	{
		// Token: 0x04000215 RID: 533
		public const string Success = "urn:oasis:names:tc:SAML:2.0:status:Success";

		// Token: 0x04000216 RID: 534
		public const string ErrorAtSP = "urn:oasis:names:tc:SAML:2.0:status:Responder";

		// Token: 0x04000217 RID: 535
		public const string Requester = "urn:oasis:names:tc:SAML:2.0:status:Requester";

		// Token: 0x04000218 RID: 536
		public const string NoPassive = "urn:oasis:names:tc:SAML:2.0:status:NoPassive";
	}
}
