using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomList))]
public class MyEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var myTarget = (RandomList)target;

        if (GUILayout.Button("Random Object"))
        {
            myTarget.Random();
        }
    }
}
