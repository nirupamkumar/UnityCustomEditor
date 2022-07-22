using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CubeEditor : EditorWindow
{
    public GameObject gameObject;
    public Vector3 spawnPositionLeft;
    public Vector3 spawnPositionRight;

    public GameObject onClick;

    [MenuItem("CustomEditor/CubeSpwan")]
    public static void ShowWindow()
    {
        GetWindow<CubeEditor>("CubeSpwan");
    }

    private void OnGUI()
    {
        GUILayout.Label("On click Spwan editor", EditorStyles.boldLabel);

        gameObject = (GameObject)EditorGUILayout.ObjectField("Spwan Object", gameObject, typeof(object), true);

        GUILayout.Label("Spawn Coordinates", EditorStyles.boldLabel);
        spawnPositionLeft = EditorGUILayout.Vector3Field("Right", spawnPositionLeft);
        spawnPositionRight = EditorGUILayout.Vector3Field("Left", spawnPositionRight);
        
        if (GUILayout.Button("Instatiate"))
        {
            //Debug.Log("Cubes instatiated on -2 and +2 local cordiantes of selected object");
            Instantiate(gameObject, spawnPositionRight, Quaternion.identity);
            Instantiate(gameObject, spawnPositionLeft, Quaternion.identity);
        }

        
    }

    void OnSceneGUI()
    {

    }
}
