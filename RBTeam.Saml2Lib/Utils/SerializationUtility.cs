using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using RBTeam.Saml2Lib.Exceptions;

namespace RBTeam.Saml2Lib.Utils
{
	// Token: 0x02000011 RID: 17
	internal static class SerializationUtility
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000035C8 File Offset: 0x000017C8
		internal static string Serialize<T>(object obj)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				using (StringWriter stringWriter = new StringWriter(stringBuilder))
				{
					XmlWriterSettings settings = new XmlWriterSettings
					{
						Indent = false,
						OmitXmlDeclaration = true
					};
					using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
					{
						new XmlSerializer(typeof(T)).Serialize(xmlWriter, obj);
					}
				}
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException(string.Concat(new object[]
				{
					"Error while serializing object of type ",
					typeof(T).FullName,
					", instance:",
					Environment.NewLine,
					obj
				}), innerException);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000036A0 File Offset: 0x000018A0
		internal static T Deserialize<T>(string str) where T : class
		{
			T result;
			try
			{
				using (StringReader stringReader = new StringReader(str))
				{
					using (XmlReader xmlReader = XmlReader.Create(stringReader))
					{
						result = (T)((object)new XmlSerializer(typeof(T)).Deserialize(xmlReader));
					}
				}
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException(string.Concat(new string[]
				{
					"Error while deserializing object of type ",
					typeof(T).FullName,
					", xml: ",
					Environment.NewLine,
					str
				}), innerException);
			}
			return result;
		}
	}
}
