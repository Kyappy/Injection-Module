using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;
using UnityEngine;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Vector4 reference support.
	/// </summary>
	[Serializable]
	public class Vector4Reference : ReferenceBase<Vector4, Vector4Variable> {}
}