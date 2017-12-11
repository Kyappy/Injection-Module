using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Double reference support.
	/// </summary>
	[Serializable]
	public class DoubleReference : ReferenceBase<double, DoubleVariable> {}
}