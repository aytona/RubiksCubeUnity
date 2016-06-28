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
            GUILayout.Label("Cube Dimensions", EditorStyles.boldLabel);
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < cubeSize.Length; i++)
            {
                GUILayout.TextArea(char.ConvertFromUtf32(i + 88) + ":", EditorStyles.miniLabel); // Might be a better way to get the char of the axis
                EditorGUILayout.IntField(cubeSize[i], GUILayout.ExpandWidth(false));
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}
