using System;

namespace RBTeam.Saml2Lib.Exceptions
{
	// Token: 0x02000023 RID: 35
	public class ConfigException : Exception
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00006010 File Offset: 0x00004210
		internal static void Check(object obj, string cfgName)
		{
			if (obj == null || (obj is string && string.IsNullOrEmpty((string)obj)) || (obj is Array && ((Array)obj).Length == 0))
			{
				throw new ConfigException("configuration value is null or empty: " + cfgName);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006050 File Offset: 0x00004250
		private ConfigException(string msg) : base(msg)
		{
		}
	}
}
