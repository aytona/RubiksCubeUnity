using UnityEditor;
using UnityEngine;
using System.Linq;

namespace EditorScripts
{
    public class CubeGenerator : EditorWindow
    {
        private int[] cubeSize;
        private GameObject[][][] cubeObj;

        [MenuItem("LevelEditor/CubeGenerator")]
        public static void OpenLevelEditorWindow()
        {
            GetWindow<CubeGenerator>(true, "Cube Generator");
        }

        void OnGUI()
        {
            if (cubeSize == null)
            {
                cubeSize = new int[3];
            }
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < cubeSize.Length; i++)
            {
                EditorGUILayout.IntField(cubeSize[i], GUILayout.ExpandWidth(false));
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}
