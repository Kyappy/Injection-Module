using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Int reference support.
	/// </summary>
	[Serializable]
	public class IntReference : ReferenceBase<int, IntVariable> {}
}