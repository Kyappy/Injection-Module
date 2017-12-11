using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Long reference support.
	/// </summary>
	[Serializable]
	public class LongReference : ReferenceBase<long, LongVariable> {}
}