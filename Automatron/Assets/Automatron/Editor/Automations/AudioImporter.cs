using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Audio Importer/Default Sample Settings/Get" )]
	class AudioImporterdefaultSampleSettingsGet0 : Automation {

		public UnityEditor.AudioImporter Instance;
		[ReadOnly]
		public UnityEditor.AudioImporterSampleSettings Result;

		public override IEnumerator Execute() {
			Result = Instance.defaultSampleSettings;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Default Sample Settings/Set" )]
	class AudioImporterdefaultSampleSettingsSet0 : Automation {

		public UnityEditor.AudioImporter Instance;
		public UnityEditor.AudioImporterSampleSettings Value;

		public override IEnumerator Execute() {
			Instance.defaultSampleSettings = Value;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Force To Mono/Get" )]
	class AudioImporterforceToMonoGet1 : Automation {

		public UnityEditor.AudioImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.forceToMono;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Force To Mono/Set" )]
	class AudioImporterforceToMonoSet1 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.forceToMono = Value;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Load In Background/Get" )]
	class AudioImporterloadInBackgroundGet2 : Automation {

		public UnityEditor.AudioImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.loadInBackground;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Load In Background/Set" )]
	class AudioImporterloadInBackgroundSet2 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.loadInBackground = Value;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Preload Audio Data/Get" )]
	class AudioImporterpreloadAudioDataGet3 : Automation {

		public UnityEditor.AudioImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.preloadAudioData;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Preload Audio Data/Set" )]
	class AudioImporterpreloadAudioDataSet3 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.preloadAudioData = Value;
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Contains Sample Settings Override" )]
	class AudioImporterContainsSampleSettingsOverride0 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.String platform;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.ContainsSampleSettingsOverride(platform);
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Get Override Sample Settings" )]
	class AudioImporterGetOverrideSampleSettings1 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.String platform;
		[ReadOnly]
		public UnityEditor.AudioImporterSampleSettings Result;

		public override IEnumerator Execute() {
			Result = Instance.GetOverrideSampleSettings(platform);
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Set Override Sample Settings" )]
	class AudioImporterSetOverrideSampleSettings2 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.String platform;
		public UnityEditor.AudioImporterSampleSettings settings;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SetOverrideSampleSettings(platform,settings);
			yield break;
		}

	}

	[Automation( "Importers/Audio Importer/Clear Sample Setting Override" )]
	class AudioImporterClearSampleSettingOverride3 : Automation {

		public UnityEditor.AudioImporter Instance;
		public System.String platform;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.ClearSampleSettingOverride(platform);
			yield break;
		}

	}


#pragma warning restore 0649
}