using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable vector3 variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Vector3 variable", fileName = "Vector3Variable")]
	public class Vector3Variable : VariableBase<Vector3> {}
}