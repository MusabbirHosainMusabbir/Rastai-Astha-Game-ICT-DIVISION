//--------------------------------------------------------------
//
//                    Car Parking Template 3.0
//        
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

// This script is CarSelect.cs Editor\Inspector layout


using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor (typeof(VehicleSelect))][CanEditMultipleObjects]
public class VehicleSelectEditor : Editor
{
	public override void OnInspectorGUI ()
	{

		serializedObject.Update ();

		EditorGUILayout.Space ();

		GUI.color = Color.green;
		EditorGUILayout.Space ();
		EditorGUILayout.HelpBox ("\n                           Vehicle Select System\n", MessageType.None);
		EditorGUILayout.Space ();
		GUI.color = Color.white;






		EditorGUILayout.HelpBox ("List of the cars", MessageType.None);

		EditorGUILayout.PropertyField (serializedObject.FindProperty ("vehicles"),
			new GUIContent ("Vehicles", "Drag youre car prefabs"), true);

		EditorGUILayout.Space ();

		EditorGUILayout.HelpBox ("Vehicle spawn point", MessageType.None);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("point"),
			new GUIContent ("Spawn Point", "Drag spawn point transform"), true);
		EditorGUILayout.Space ();



		EditorGUILayout.HelpBox ("List of the car prices", MessageType.None);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("Values"),
			new GUIContent ("Vehicle Price List", "Enter list of the car prices"), true);
		EditorGUILayout.Space ();



		EditorGUILayout.HelpBox ("Icon - Button - Shop", MessageType.None);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("Lock"),
			new GUIContent ("Lock Icon", "Drag lock icon image   "), true);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("Shop"),
			new GUIContent ("Shop Window", "Drag Shop Window image   "), true);

		EditorGUILayout.PropertyField (serializedObject.FindProperty ("Buy"),
			new GUIContent ("Buy Button", "Buy Button Object   "), true);
		EditorGUILayout.Space ();

		EditorGUILayout.PropertyField (serializedObject.FindProperty ("vehiclePriceText"),
			new GUIContent ("Vehicle Price Text", "Drag Vehicle Price Text   "), true);
		EditorGUILayout.Space ();



		EditorGUILayout.HelpBox ("Main Level Name", MessageType.None);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("levelName"),
			new GUIContent ("Level Name ", "Enter Main Scene Day Mode Name  "), true);
		EditorGUILayout.Space ();

		EditorGUILayout.HelpBox ("Loading Window", MessageType.None);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("Loading"),
			new GUIContent ("Loading Object", "Drag Loading GameObject  "), true);
		EditorGUILayout.Space ();

		EditorGUILayout.HelpBox ("Customization", MessageType.None);

		EditorGUILayout.PropertyField (serializedObject.FindProperty ("mainMenu"),
			new GUIContent ("Main Menu", "Drag RingSport Component  "), true);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("customizeMenu"),
			new GUIContent ("Customize Menu", "Drag RingSport Component  "), true);
		EditorGUILayout.PropertyField (serializedObject.FindProperty ("selectButtons"),
			new GUIContent ("Select Buttons", "Drag RingSport Component  "), true);

		serializedObject.ApplyModifiedProperties ();

	}

}


