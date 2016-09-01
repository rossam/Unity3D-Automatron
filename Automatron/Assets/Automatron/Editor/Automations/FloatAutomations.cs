using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Single/Get Epsilon" )]
	class SingleEpsilonGet0 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.Epsilon;
			yield break;
		}

	}

	[Automation( "Single/Get Max Value" )]
	class SingleMaxValueGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.MaxValue;
			yield break;
		}

	}

	[Automation( "Single/Get Min Value" )]
	class SingleMinValueGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.MinValue;
			yield break;
		}

	}

	[Automation( "Single/Get Na N" )]
	class SingleNaNGet3 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.NaN;
			yield break;
		}

	}

	[Automation( "Single/Get Positive Infinity" )]
	class SinglePositiveInfinityGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.PositiveInfinity;
			yield break;
		}

	}

	[Automation( "Single/Get Negative Infinity" )]
	class SingleNegativeInfinityGet5 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.NegativeInfinity;
			yield break;
		}

	}

	[Automation( "Single/Is Infinity" )]
	class SingleIsInfinity0 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsInfinity(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Single/Is Na N" )]
	class SingleIsNaN1 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsNaN(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Single/Is Negative Infinity" )]
	class SingleIsNegativeInfinity2 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsNegativeInfinity(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Single/Is Positive Infinity" )]
	class SingleIsPositiveInfinity3 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsPositiveInfinity(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Single/Parse" )]
	class SingleParse4 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.Parse(s);
			yield break;
		}

	}

	[Automation( "Single/Try Parse" )]
	class SingleTryParse5 : ConditionalAutomation {

		public System.String s;
		public System.Single result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Single/To String" )]
	class SingleToString6 : Automation {

		public System.Single Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
