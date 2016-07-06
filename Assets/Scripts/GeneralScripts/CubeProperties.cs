using UnityEngine;

namespace Aytona
{
    public class CubeProperties
    {
        #region Singleton
        private static CubeProperties instance;
        private CubeProperties() { }
        public static CubeProperties Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CubeProperties();
                }
                return instance;
            }
        }
        #endregion

    }
}
