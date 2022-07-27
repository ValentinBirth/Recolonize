using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(MapGenerator))]
[CanEditMultipleObjects]
public class ScriptEditor : Editor
{
    MapGenerator mp;
    public override void OnInspectorGUI(){
            mp = (MapGenerator)target;
            DrawDefaultInspector();
            if(GUILayout.Button("Generate Map")){
                mp.GenerateMap();
            }
        }
}