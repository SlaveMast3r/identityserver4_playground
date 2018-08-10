using System;
using System.Collections.Generic;
using System.Linq;
using RBTeam.Saml2Lib.Configuration;
using RBTeam.Saml2Lib.Data.Model;

namespace RBTeam.Saml2Lib.Services
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	internal abstract class UserDataStoreBase
	{
		// Token: 0x060000AB RID: 171 RVA: 0x000057DD File Offset: 0x000039DD
		protected UserDataStoreBase()
		{
			this.cache = new Dictionary<string, UserData>();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000057F0 File Offset: 0x000039F0
		internal void Set(Saml2Config config, string key, object value)
		{
			this.SetInternal(config, this.cache, new List<string>
			{
				key
			}, value, false);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000580D File Offset: 0x00003A0D
		internal void Set(Saml2Config config, string sessionIndex, string key, object value)
		{
			this.SetInternal(config, this.cache, new List<string>
			{
				sessionIndex,
				key
			}, value, false);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005832 File Offset: 0x00003A32
		internal void SetExpirable(Saml2Config config, string key, object value)
		{
			this.SetInternal(config, this.cache, new List<string>
			{
				key
			}, value, true);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000584F File Offset: 0x00003A4F
		internal void SetExpirable(Saml2Config config, string sessionIndex, string key, object value)
		{
			this.SetInternal(config, this.cache, new List<string>
			{
				sessionIndex,
				key
			}, value, true);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005874 File Offset: 0x00003A74
		internal T Get<T>(Saml2Config config, string key) where T : class
		{
			this.RemoveOldData(config, this.cache);
			UserData @internal = this.GetInternal(this.cache, new List<string>
			{
				key
			});
			return (T)((object)((@internal != null) ? @internal.Data : null));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000058AC File Offset: 0x00003AAC
		internal T Get<T>(Saml2Config config, string sessionIndex, string key) where T : class
		{
			this.RemoveOldData(config, this.cache);
			UserData @internal = this.GetInternal(this.cache, new List<string>
			{
				sessionIndex,
				key
			});
			return (T)((object)((@internal != null) ? @internal.Data : null));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000058EB File Offset: 0x00003AEB
		internal void Clear(string key)
		{
			this.SetInternal(null, this.cache, new List<string>
			{
				key
			}, null, false);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005908 File Offset: 0x00003B08
		internal void Clear(string sessionIndex, string key)
		{
			this.SetInternal(null, this.cache, new List<string>
			{
				sessionIndex,
				key
			}, null, false);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000592C File Offset: 0x00003B2C
		private void SetInternal(Saml2Config config, IDictionary<string, UserData> cache, IList<string> keys, object value, bool expires)
		{
			if (keys.Count > 1)
			{
				if (!cache.ContainsKey(keys[0]))
				{
					Dictionary<string, UserData> value2 = new Dictionary<string, UserData>();
					cache[keys[0]] = new UserData(value2);
					keys.RemoveAt(0);
					this.SetInternal(config, value2, keys, value, expires);
					return;
				}
				string key = keys[0];
				Dictionary<string, UserData> dict = cache[key].Dict;
				keys.RemoveAt(0);
				this.SetInternal(config, dict, keys, value, expires);
				if (dict.Count == 0)
				{
					cache.Remove(key);
					return;
				}
			}
			else
			{
				if (value != null)
				{
					UserData userData;
					if (cache.ContainsKey(keys[0]))
					{
						userData = cache[keys[0]];
					}
					else
					{
						userData = new UserData();
						cache[keys[0]] = userData;
					}
					userData.Data = value;
					userData.Expires = expires;
					userData.Creation = config.GlobalContext.DateTimeNow;
					return;
				}
				if (cache.ContainsKey(keys[0]))
				{
					cache.Remove(keys[0]);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005A34 File Offset: 0x00003C34
		private UserData GetInternal(IDictionary<string, UserData> cache, IList<string> keys)
		{
			if (keys.Count <= 1)
			{
				if (!cache.ContainsKey(keys[0]))
				{
					return null;
				}
				return cache[keys[0]];
			}
			else
			{
				if (!cache.ContainsKey(keys[0]))
				{
					return null;
				}
				string key = keys[0];
				Dictionary<string, UserData> dict = cache[key].Dict;
				keys.RemoveAt(0);
				return this.GetInternal(dict, keys);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005AA0 File Offset: 0x00003CA0
		private void RemoveOldData(Saml2Config config, Dictionary<string, UserData> cache)
		{
			IEnumerable<string> keys = cache.Keys;
            foreach (string key3 in keys.Where((string key) => cache[key].Dict != null))
            {
                this.RemoveOldData(config, cache[key3].Dict);
            }
            List<string> list = new List<string>();
            foreach (string text in cache.Keys)
            {
                UserData userData = cache[text];
                if (userData.Expires && config.GlobalContext.DateTimeNow.ToUniversalTime() > userData.Creation + TimeSpan.FromSeconds((double)config.DataCache.SamlRequestLifespanSeconds))
                {
                    list.Add(text);
                }
                else if (cache[text].Dict != null && cache[text].Dict.Count == 0)
                {
                    list.Add(text);
                }
            }
            foreach (string key2 in list)
            {
                cache.Remove(key2);
            }
        }

		// Token: 0x060000B7 RID: 183 RVA: 0x00005C5C File Offset: 0x00003E5C
		internal void Store(Saml2Config config)
		{
			this.StoreCache(this.cache, config);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005C6B File Offset: 0x00003E6B
		internal void Load(Saml2Config config)
		{
			this.cache = this.LoadCache(config);
		}

		// Token: 0x060000B9 RID: 185
		protected internal abstract void StoreCache(Dictionary<string, UserData> cache, Saml2Config config);

		// Token: 0x060000BA RID: 186
		protected internal abstract Dictionary<string, UserData> LoadCache(Saml2Config config);

		// Token: 0x0400003B RID: 59
		private Dictionary<string, UserData> cache;
	}
}
