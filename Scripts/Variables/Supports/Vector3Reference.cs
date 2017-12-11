using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;
using UnityEngine;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Vector3 reference support.
	/// </summary>
	[Serializable]
	public class Vector3Reference : ReferenceBase<Vector3, Vector3Variable> {}
}