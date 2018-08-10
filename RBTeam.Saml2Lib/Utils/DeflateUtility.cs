using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x0200000B RID: 11
	internal static class DeflateUtility
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002EC8 File Offset: 0x000010C8
		internal static byte[] Zip(byte[] data)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))
				{
					deflateStream.Write(data, 0, data.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002F2C File Offset: 0x0000112C
		internal static string UnZip(byte[] data)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
				{
					using (StreamReader streamReader = new StreamReader(deflateStream, Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
					}
				}
			}
			return result;
		}
	}
}
