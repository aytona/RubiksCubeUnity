using UnityEngine;

namespace Aytona
{
    public class CreateCube : MonoBehaviour
    {
        public static void NewCube(Vector3 cubeDimensions)
        {
            GameObject rootObj = GameObject.Find("Cube");
            if (rootObj != null)
            {
                DestroyImmediate(rootObj);
            }
            rootObj = new GameObject();
            rootObj.name = "Cube";
        }
    }
}       
                   