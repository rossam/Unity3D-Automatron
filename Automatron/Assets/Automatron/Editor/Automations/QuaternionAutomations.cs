using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Quaternion/Get X" )]
	class QuaternionxGet0 : Automation {

		public UnityEngine.Quaternion Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.x;
			yield break;
		}

	}

	[Automation( "Quaternion/Set X" )]
	class QuaternionxSet0 : Automation {

		public UnityEngine.Quaternion Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.x = Value;
			yield break;
		}

	}

	[Automation( "Quaternion/Get Y" )]
	class QuaternionyGet1 : Automation {

		public UnityEngine.Quaternion Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.y;
			yield break;
		}

	}

	[Automation( "Quaternion/Set Y" )]
	class QuaternionySet1 : Automation {

		public UnityEngine.Quaternion Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.y = Value;
			yield break;
		}

	}

	[Automation( "Quaternion/Get Z" )]
	class QuaternionzGet2 : Automation {

		public UnityEngine.Quaternion Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.z;
			yield break;
		}

	}

	[Automation( "Quaternion/Set Z" )]
	class QuaternionzSet2 : Automation {

		public UnityEngine.Quaternion Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.z = Value;
			yield break;
		}

	}

	[Automation( "Quaternion/Get W" )]
	class QuaternionwGet3 : Automation {

		public UnityEngine.Quaternion Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.w;
			yield break;
		}

	}

	[Automation( "Quaternion/Set W" )]
	class QuaternionwSet3 : Automation {

		public UnityEngine.Quaternion Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.w = Value;
			yield break;
		}

	}

	[Automation( "Quaternion/Get Identity" )]
	class QuaternionidentityGet0 : Automation {

		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.identity;
			yield break;
		}

	}

	[Automation( "Quaternion/Get Euler Angles" )]
	class QuaternioneulerAnglesGet1 : Automation {

		public UnityEngine.Quaternion Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.eulerAngles;
			yield break;
		}

	}

	[Automation( "Quaternion/Set Euler Angles" )]
	class QuaternioneulerAnglesSet1 : Automation {

		public UnityEngine.Quaternion Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.eulerAngles = Value;
			yield break;
		}

	}

	[Automation( "Quaternion/Dot" )]
	class QuaternionDot0 : Automation {

		public UnityEngine.Quaternion a;
		public UnityEngine.Quaternion b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.Dot(a,b);
			yield break;
		}

	}

	[Automation( "Quaternion/Angle Axis" )]
	class QuaternionAngleAxis1 : Automation {

		public System.Single angle;
		public UnityEngine.Vector3 axis;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.AngleAxis(angle,axis);
			yield break;
		}

	}

	[Automation( "Quaternion/To Angle Axis" )]
	class QuaternionToAngleAxis2 : Automation {

		public UnityEngine.Quaternion Instance;
		public System.Single angle;
		public UnityEngine.Vector3 axis;

		public override IEnumerator Execute() {
			Instance.ToAngleAxis(out angle,out axis);
			yield break;
		}

	}

	[Automation( "Quaternion/From To Rotation" )]
	class QuaternionFromToRotation3 : Automation {

		public UnityEngine.Vector3 fromDirection;
		public UnityEngine.Vector3 toDirection;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.FromToRotation(fromDirection,toDirection);
			yield break;
		}

	}

	[Automation( "Quaternion/Set From To Rotation" )]
	class QuaternionSetFromToRotation4 : Automation {

		public UnityEngine.Quaternion Instance;
		public UnityEngine.Vector3 fromDirection;
		public UnityEngine.Vector3 toDirection;

		public override IEnumerator Execute() {
			Instance.SetFromToRotation(fromDirection,toDirection);
			yield break;
		}

	}

	[Automation( "Quaternion/Look Rotation" )]
	class QuaternionLookRotation5 : Automation {

		public UnityEngine.Vector3 forward;
		public UnityEngine.Vector3 upwards;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.LookRotation(forward,upwards);
			yield break;
		}

	}

	[Automation( "Quaternion/Set Look Rotation" )]
	class QuaternionSetLookRotation6 : Automation {

		public UnityEngine.Quaternion Instance;
		public UnityEngine.Vector3 view;
		public UnityEngine.Vector3 up;

		public override IEnumerator Execute() {
			Instance.SetLookRotation(view,up);
			yield break;
		}

	}

	[Automation( "Quaternion/Slerp" )]
	class QuaternionSlerp7 : Automation {

		public UnityEngine.Quaternion a;
		public UnityEngine.Quaternion b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.Slerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Quaternion/Slerp Unclamped" )]
	class QuaternionSlerpUnclamped8 : Automation {

		public UnityEngine.Quaternion a;
		public UnityEngine.Quaternion b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.SlerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Quaternion/Lerp" )]
	class QuaternionLerp9 : Automation {

		public UnityEngine.Quaternion a;
		public UnityEngine.Quaternion b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Quaternion/Lerp Unclamped" )]
	class QuaternionLerpUnclamped10 : Automation {

		public UnityEngine.Quaternion a;
		public UnityEngine.Quaternion b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Quaternion/Rotate Towards" )]
	class QuaternionRotateTowards11 : Automation {

		public UnityEngine.Quaternion from;
		public UnityEngine.Quaternion to;
		public System.Single maxDegreesDelta;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.RotateTowards(from,to,maxDegreesDelta);
			yield break;
		}

	}

	[Automation( "Quaternion/Inverse" )]
	class QuaternionInverse12 : Automation {

		public UnityEngine.Quaternion rotation;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.Inverse(rotation);
			yield break;
		}

	}

	[Automation( "Quaternion/Angle" )]
	class QuaternionAngle13 : Automation {

		public UnityEngine.Quaternion a;
		public UnityEngine.Quaternion b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.Angle(a,b);
			yield break;
		}

	}

	[Automation( "Quaternion/Euler" )]
	class QuaternionEuler15 : Automation {

		public UnityEngine.Vector3 euler;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Quaternion.Euler(euler);
			yield break;
		}

	}


#pragma warning restore 0649
}
