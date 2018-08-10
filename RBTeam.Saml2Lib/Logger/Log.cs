using System;
//using NLog;

namespace RBTeam.Saml2Lib.Logger
{
    // Token: 0x02000022 RID: 34
    public class Log : ILog
    {
        // Token: 0x060000D4 RID: 212 RVA: 0x00005F43 File Offset: 0x00004143
        public void Trace(string text, params object[] args)
        {
            //Log.logger.Trace(text, args);
        }

        // Token: 0x060000D5 RID: 213 RVA: 0x00005F51 File Offset: 0x00004151
        public void Trace(Exception exception, string text)
        {
            //Log.logger.Trace(exception, text, Array.Empty<object>());
        }

        // Token: 0x060000D6 RID: 214 RVA: 0x00005F64 File Offset: 0x00004164
        public void Debug(string text)
        {
            //Log.logger.Debug(text);
        }

        // Token: 0x060000D7 RID: 215 RVA: 0x00005F71 File Offset: 0x00004171
        public void Debug(Exception exception, string text)
        {
            //Log.logger.Debug(exception, text, Array.Empty<object>());
        }

        // Token: 0x060000D8 RID: 216 RVA: 0x00005F84 File Offset: 0x00004184
        public void Info(string text)
        {
            //Log.logger.Info(text);
        }

        // Token: 0x060000D9 RID: 217 RVA: 0x00005F91 File Offset: 0x00004191
        public void Info(Exception exception, string text)
        {
            //Log.logger.Info(exception, text, Array.Empty<object>());
        }

        // Token: 0x060000DA RID: 218 RVA: 0x00005FA4 File Offset: 0x000041A4
        public void Warn(string text)
        {
            //Log.logger.Warn(text);
        }

        // Token: 0x060000DB RID: 219 RVA: 0x00005FB1 File Offset: 0x000041B1
        public void Warn(Exception exception, string text)
        {
            //Log.logger.Warn(exception, text, Array.Empty<object>());
        }

        // Token: 0x060000DC RID: 220 RVA: 0x00005FC4 File Offset: 0x000041C4
        public void Error(string text)
        {
            //Log.logger.Error(text);
        }

        // Token: 0x060000DD RID: 221 RVA: 0x00005FD1 File Offset: 0x000041D1
        public void Error(Exception exception, string text)
        {
            //Log.logger.Error(exception, text, Array.Empty<object>());
        }

        // Token: 0x060000DE RID: 222 RVA: 0x00005FE4 File Offset: 0x000041E4
        public void Fatal(string text)
        {
            //Log.logger.Fatal(text);
        }

        // Token: 0x060000DF RID: 223 RVA: 0x00005FF1 File Offset: 0x000041F1
        public void Fatal(Exception exception, string text)
        {
            //Log.logger.Fatal(exception, text, Array.Empty<object>());
        }

        // Token: 0x0400003E RID: 62
        //private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    }
}
