using UnityEngine;

namespace Assets.Levels
{
    public class Level3 : ILevel
    {
        public void Start()
        {
            Physics.gravity = new Vector3(0, -35, 0);
        }

        public void Reset()
        {
            Physics.gravity = new Vector3(0, 0, 0);
        }
    }
}
