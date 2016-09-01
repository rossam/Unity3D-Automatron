using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Colliders/Box Collider/Get Center" )]
	class BoxCollidercenterGet0 : Automation {

		public UnityEngine.BoxCollider Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Colliders/Box Collider/Set Center" )]
	class BoxCollidercenterSet0 : Automation {

		public UnityEngine.BoxCollider Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Box Collider/Get Size" )]
	class BoxCollidersizeGet1 : Automation {

		public UnityEngine.BoxCollider Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Colliders/Box Collider/Set Size" )]
	class BoxCollidersizeSet1 : Automation {

		public UnityEngine.BoxCollider Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
