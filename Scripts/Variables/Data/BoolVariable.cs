using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable bool variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Bool variable", fileName = "BoolVariable")]
	public class BoolVariable : VariableBase<bool> {}
}