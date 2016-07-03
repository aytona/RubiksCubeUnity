using UnityEngine;
using Aytona;

namespace InGameScripts
{
    public class GameUI
    {
        private int[] cubeSize = new int[3];
        private GameObject cubeObj;

        void Start()
        {
            cubeObj = GameObject.Find("Cube");
            for (int i = 0; i < cubeSize.Length; i++)
            {
                // TODO: Readable cube properties
            }
        }

        void Update()
        {

        }

        public void GenerateNewCube()
        {
            if (cubeSize[0] == 0 || cubeSize[1] == 0 || cubeSize[2] == 0)
            {
                return;
            }
            CreateCube.NewCube(new Vector3(cubeSize[0], cubeSize[1], cubeSize[2]));
        }
    }
}