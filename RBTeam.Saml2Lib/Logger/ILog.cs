using System;

namespace RBTeam.Saml2Lib.Logger
{
	// Token: 0x02000021 RID: 33
	public interface ILog
	{
		// Token: 0x060000C8 RID: 200
		void Trace(string text, params object[] args);

		// Token: 0x060000C9 RID: 201
		void Trace(Exception exception, string text);

		// Token: 0x060000CA RID: 202
		void Debug(string text);

		// Token: 0x060000CB RID: 203
		void Debug(Exception exception, string text);

		// Token: 0x060000CC RID: 204
		void Info(string text);

		// Token: 0x060000CD RID: 205
		void Info(Exception exception, string text);

		// Token: 0x060000CE RID: 206
		void Warn(string text);

		// Token: 0x060000CF RID: 207
		void Warn(Exception exception, string text);

		// Token: 0x060000D0 RID: 208
		void Error(string text);

		// Token: 0x060000D1 RID: 209
		void Error(Exception exception, string text);

		// Token: 0x060000D2 RID: 210
		void Fatal(string text);

		// Token: 0x060000D3 RID: 211
		void Fatal(Exception exception, string text);
	}
}
