using System;
using System.Configuration;
using System.IO;
using RBTeam.Saml2Lib.Data.Infra;
using RBTeam.Saml2Lib.Data.Messages;
using RBTeam.Saml2Lib.Exceptions;
using RBTeam.Saml2Lib.Logger;
using RBTeam.Saml2Lib.MessageProcessing;
using RBTeam.Saml2Lib.Utils;

namespace RBTeam.Saml2Lib.Configuration
{
	// Token: 0x020000BE RID: 190
	public class Saml2Config : ConfigurationSection
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0000941A File Offset: 0x0000761A
		public EntityDescriptorType SpMetadata
		{
			get
			{
				if (this.spMetadata == null)
				{
					this.ReadFiles();
				}
				return this.spMetadata;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00009430 File Offset: 0x00007630
		public EntityDescriptorType IdpMetadata
		{
			get
			{
				if (this.idpMetadata == null)
				{
					this.ReadFiles();
				}
				return this.idpMetadata;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00009446 File Offset: 0x00007646
		public string PostBindingHtml
		{
			get
			{
				if (this.postBindingHtml == null)
				{
					this.ReadFiles();
				}
				return this.postBindingHtml;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000945C File Offset: 0x0000765C
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00009464 File Offset: 0x00007664
		public IGlobalContext GlobalContext { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0000946D File Offset: 0x0000766D
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00009475 File Offset: 0x00007675
		public string SessionIndex { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0000947E File Offset: 0x0000767E
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00009486 File Offset: 0x00007686
		public NameIDType NameId { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0000948F File Offset: 0x0000768F
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00009497 File Offset: 0x00007697
		public IHttpContext HttpContext { get; set; }

		// Token: 0x0600053E RID: 1342 RVA: 0x000094A0 File Offset: 0x000076A0
		internal static ISaml2Sender CreateSender(ILog log)
		{
			return new SendPipeline(log);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000094A8 File Offset: 0x000076A8
		internal static ISaml2Receiver CreateReceiver(ILog log)
		{
			return new ReceivePipeline(log);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000094B0 File Offset: 0x000076B0
		private void ReadFiles()
		{
			string path = this.ResolveFilePath(this.PostBindingHtmlFile);
			try
			{
				this.postBindingHtml = File.ReadAllText(path);
			}
			catch
			{
			}
			string text = this.ResolveFilePath(this.SpMetadataFile);
			try
			{
				this.spMetadata = SerializationUtility.Deserialize<EntityDescriptorType>(File.ReadAllText(text));
			}
			catch (Exception innerException)
			{
				throw new Saml2ModuleException("Unable to read sp metadata from file: " + text, innerException);
			}
			string text2 = this.ResolveFilePath(this.IdpMetadataFile);
			try
			{
				this.idpMetadata = SerializationUtility.Deserialize<EntityDescriptorType>(File.ReadAllText(text2));
			}
			catch (Exception innerException2)
			{
				throw new Saml2ModuleException("Unable to read idp metadata from file: " + text2, innerException2);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000956C File Offset: 0x0000776C
		private string ResolveFilePath(string file)
		{
			if (this.HttpContext == null)
			{
				throw new Saml2ModuleException("HttpContext is null");
			}
			ConfigException.Check(this.HttpContext, "Saml2Config.HttpContext");
			if (Path.IsPathRooted(file))
			{
				return file;
			}
			return Path.Combine(this.HttpContext.ApplicationPath, file);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x000095AC File Offset: 0x000077AC
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x000095BE File Offset: 0x000077BE
		[ConfigurationProperty("spMetadataFile", IsRequired = true)]
		public string SpMetadataFile
		{
			get
			{
				return (string)base["spMetadataFile"];
			}
			set
			{
				base["spMetadataFile"] = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x000095CC File Offset: 0x000077CC
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x000095DE File Offset: 0x000077DE
		[ConfigurationProperty("idpMetadataFile", IsRequired = true)]
		public string IdpMetadataFile
		{
			get
			{
				return (string)base["idpMetadataFile"];
			}
			set
			{
				base["idpMetadataFile"] = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x000095EC File Offset: 0x000077EC
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x000095FE File Offset: 0x000077FE
		[ConfigurationProperty("postBindingHtmlFile", IsRequired = true)]
		public string PostBindingHtmlFile
		{
			get
			{
				return (string)base["postBindingHtmlFile"];
			}
			set
			{
				base["postBindingHtmlFile"] = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0000960C File Offset: 0x0000780C
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x0000961E File Offset: 0x0000781E
		[ConfigurationProperty("timeTolerance")]
		[IntegerValidator(ExcludeRange = false, MinValue = 0, MaxValue = 86400)]
		public int TimeToleranceSeconds
		{
			get
			{
				return (int)base["timeTolerance"];
			}
			set
			{
				base["timeTolerance"] = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00009631 File Offset: 0x00007831
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00009643 File Offset: 0x00007843
		[ConfigurationProperty("outgoingMessages")]
		public Saml2OutgoingMessagesConfig OutgoingMessages
		{
			get
			{
				return (Saml2OutgoingMessagesConfig)base["outgoingMessages"];
			}
			set
			{
				base["outgoingMessages"] = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00009651 File Offset: 0x00007851
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00009663 File Offset: 0x00007863
		[ConfigurationProperty("incomingMessages")]
		public Saml2IncomingMessagesConfig IncomingMessages
		{
			get
			{
				return (Saml2IncomingMessagesConfig)base["incomingMessages"];
			}
			set
			{
				base["incomingMessages"] = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00009671 File Offset: 0x00007871
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00009683 File Offset: 0x00007883
		[ConfigurationProperty("certificateStore")]
		public CertificateStoreConfig CertificateStore
		{
			get
			{
				return (CertificateStoreConfig)base["certificateStore"];
			}
			set
			{
				base["certificateStore"] = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00009691 File Offset: 0x00007891
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x000096A3 File Offset: 0x000078A3
		[ConfigurationProperty("dataCache")]
		public DataCacheConfig DataCache
		{
			get
			{
				return (DataCacheConfig)base["dataCache"];
			}
			set
			{
				base["dataCache"] = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x000096B1 File Offset: 0x000078B1
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x000096C3 File Offset: 0x000078C3
		[ConfigurationProperty("assertionAttributes")]
		public AssertionAttributesConfig AssertionAttributes
		{
			get
			{
				return (AssertionAttributesConfig)base["assertionAttributes"];
			}
			set
			{
				base["assertionAttributes"] = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000096D1 File Offset: 0x000078D1
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000096E3 File Offset: 0x000078E3
		[ConfigurationProperty("samlRefreshUrl", IsRequired = true)]
		public string SamlRefreshUrl
		{
			get
			{
				return (string)base["samlRefreshUrl"];
			}
			set
			{
				base["samlRefreshUrl"] = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000096F1 File Offset: 0x000078F1
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00009703 File Offset: 0x00007903
		[ConfigurationProperty("samlRefreshInterval", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MinValue = 0, MaxValue = 86400)]
		public int SamlRefreshInterval
		{
			get
			{
				return (int)base["samlRefreshInterval"];
			}
			set
			{
				base["samlRefreshInterval"] = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00009716 File Offset: 0x00007916
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00009728 File Offset: 0x00007928
		[ConfigurationProperty("sessionExpirationOffset", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MinValue = 0, MaxValue = 86400)]
		public int SessionExpirationOffset
		{
			get
			{
				return (int)base["sessionExpirationOffset"];
			}
			set
			{
				base["sessionExpirationOffset"] = value;
			}
		}

		// Token: 0x04000222 RID: 546
		private EntityDescriptorType spMetadata;

		// Token: 0x04000223 RID: 547
		private EntityDescriptorType idpMetadata;

		// Token: 0x04000224 RID: 548
		private string postBindingHtml;
	}
}
