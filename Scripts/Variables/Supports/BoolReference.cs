using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Bool reference support.
	/// </summary>
	[Serializable]
	public class BoolReference : ReferenceBase<bool, BoolVariable> {}
}