using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;
using UnityEngine;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Vector3Int reference support.
	/// </summary>
	[Serializable]
	public class Vector3IntReference : ReferenceBase<Vector3Int, Vector3IntVariable> {}
}