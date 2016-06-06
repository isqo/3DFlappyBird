using UnityEngine;

namespace Assets.Levels
{
    public class Level1 : ILevel
    {
        public void Start()
        {
            Physics.gravity = new Vector3(0, -19, 0);
        }

        public void Reset()
        {
            Physics.gravity = new Vector3(0, 0, 0);
        }
    }
}
