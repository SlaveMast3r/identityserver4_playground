using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Messages;

namespace RBTeam.Saml2Lib.Data.Model
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	internal class AssertionAttributes
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000060D8 File Offset: 0x000042D8
		internal AssertionAttributes(IEnumerable<StatementAbstractType> items)
		{
			this.attributeDict = new Dictionary<string, List<string>>();
			this.LoadAttributes(items);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000060F4 File Offset: 0x000042F4
		private void LoadAttributes(IEnumerable<StatementAbstractType> items)
		{
			object obj;
			if (items == null)
			{
				obj = null;
			}
			else
			{
				obj = items.FirstOrDefault((StatementAbstractType item) => item is AttributeStatementType);
			}
			AttributeStatementType attributeStatementType = (AttributeStatementType)obj;
			if (((attributeStatementType != null) ? attributeStatementType.Items : null) == null)
			{
				return;
			}
			object[] items2 = attributeStatementType.Items;
			for (int i = 0; i < items2.Length; i++)
			{
				AttributeType attributeType = items2[i] as AttributeType;
				if (attributeType != null)
				{
					List<string> list = new List<string>();
					if (attributeType.AttributeValue != null)
					{
						list.AddRange(attributeType.AttributeValue.OfType<string>());
					}
					if (list.Count > 0)
					{
						this.attributeDict.Add(attributeType.Name, list);
					}
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000061A0 File Offset: 0x000043A0
		internal void MapAttributeValues(AssertionAttributesConfig attrConfig)
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			foreach (string text in this.attributeDict.Keys)
			{
				List<string> list = this.attributeDict[text];
				List<string> list2 = new List<string>();
				if (text == attrConfig.RolesAttribute)
				{
					using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string text2 = enumerator2.Current;
							foreach (object obj in attrConfig)
							{
								RoleMappingRecord roleMappingRecord = (RoleMappingRecord)obj;
								Match match = new Regex(roleMappingRecord.Regex.Replace("{role}", "<role>").ToLower()).Match(text2.ToLower());
								if (match.Success)
								{
									string text3 = match.Groups["role"].Value;
									if (!string.IsNullOrEmpty(roleMappingRecord.Prefix))
									{
										text3 = roleMappingRecord.Prefix.Trim() + "." + text3;
									}
									list2.Add(text3.ToUpper());
								}
								else
								{
									list2.Add(text2);
								}
							}
						}
						goto IL_14C;
					}
					goto IL_149;
				}
				goto IL_149;
				IL_14C:
				dictionary[text] = list2;
				continue;
				IL_149:
				list2 = list;
				goto IL_14C;
			}
			this.attributeDict = dictionary;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006374 File Offset: 0x00004574
		internal IEnumerable<string> GetAttributeNames()
		{
			return this.attributeDict.Keys.ToList<string>();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006386 File Offset: 0x00004586
		internal string GetValue(string name)
		{
			if (!this.attributeDict.ContainsKey(name))
			{
				return null;
			}
			return this.attributeDict[name][0];
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000063AA File Offset: 0x000045AA
		internal List<string> GetMultiValue(string name)
		{
			if (!this.attributeDict.ContainsKey(name))
			{
				return new List<string>();
			}
			return this.attributeDict[name];
		}

		// Token: 0x04000041 RID: 65
		private Dictionary<string, List<string>> attributeDict;
	}
}
