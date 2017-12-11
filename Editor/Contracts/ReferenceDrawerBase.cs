using System;
using Modules.InjectionModule.Supports;
using UnityEditor;
using UnityEngine;

namespace Modules.InjectionModule.Contracts {
	/// <summary>
	/// Reference drawer base class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class ReferenceDrawerBase : PropertyDrawer {
		#region Private fields
		/// <summary>
		/// The selected reference type.
		/// </summary>
		private ReferenceType selectedReferenceType = ReferenceType.UseConstant;
		#endregion

		#region PropertyDrawer public methods
		/// <summary>
		/// Called when [GUI] is drawn.
		/// </summary>
		/// <param name="position">The position of the property in the inspector.</param>
		/// <param name="property">The property to draw.</param>
		/// <param name="label">The label of the property.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			EditorGUI.BeginProperty(position, label, property);
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
			var indent = EditorGUI.indentLevel;
			EditorGUI.indentLevel = 0;

			var referenceTypeRect = new Rect(position.x, position.y + 4, 15, position.height);
			var valueRect = new Rect(position.x + 20, position.y, position.width - 20, position.height);
			selectedReferenceType = (ReferenceType) EditorGUI.EnumPopup(referenceTypeRect, selectedReferenceType, new GUIStyle("PaneOptions") {imagePosition = ImagePosition.ImageOnly});

			switch (selectedReferenceType) {
				case ReferenceType.UseConstant:
					EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("ConstantValue"), GUIContent.none);
					break;
				case ReferenceType.UseVariable:
					EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("Variable"), GUIContent.none);
					break;
				default: throw new ArgumentOutOfRangeException();
			}

			EditorGUI.indentLevel = indent;
			EditorGUI.EndProperty();
		}
		#endregion
	}
}