using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable ushort variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Unsigned short variable", fileName = "UShortVariable")]
	public class UShortVariable : VariableBase<ushort> {}
}