using System;

namespace RBTeam.Saml2Lib.Exceptions
{
	// Token: 0x02000024 RID: 36
	public class MissingModelDataException : Exception
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00006059 File Offset: 0x00004259
		internal static void Check(object obj, string propertyName)
		{
			if (obj == null || (obj is string && string.IsNullOrEmpty((string)obj)))
			{
				throw new MissingModelDataException("missing data in message model: " + propertyName);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006050 File Offset: 0x00004250
		private MissingModelDataException(string msg) : base(msg)
		{
		}
	}
}
