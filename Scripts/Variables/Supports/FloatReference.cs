using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Float reference support.
	/// </summary>
	[Serializable]
	public class FloatReference : ReferenceBase<float, FloatVariable> {}
}