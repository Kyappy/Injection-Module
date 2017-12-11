using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable vector3Int variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Vector3 integer variable", fileName = "Vector3IntVariable")]
	public class Vector3IntVariable : VariableBase<Vector3Int> {}
}