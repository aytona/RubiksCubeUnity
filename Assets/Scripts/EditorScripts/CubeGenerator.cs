using UnityEditor;
using UnityEngine;

namespace EditorScripts
{
    public class CubeGenerator : EditorWindow
    {
        private Vector3 cubeSize;
        private GameObject[][][] cubeObj;

        [MenuItem("LevelEditor/CubeGenerator")]
        public static void OpenLevelEditorWindow()
        {
            GetWindow<CubeGenerator>(true, "Cube Generator");
        }

        void OnGUI()
        {
            cubeSize = EditorGUILayout.Vector3Field("Cube Dimensions", cubeSize, GUILayout.ExpandWidth(false));
            if (GUILayout.Button("Generate", GUILayout.ExpandWidth(false)))
            {
                if (cubeSize.x  == 0|| cubeSize.y == 0 || cubeSize.z == 0)
                {
                    ShowNotification(new GUIContent("Values must be all nonzero"));
                    return;
                }
                
                GenerateNewCube(cubeSize);
            }
        }

        private void GenerateNewCube(Vector3 cubeDimension)
        {

        }
    }
}
