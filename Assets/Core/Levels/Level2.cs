using UnityEngine;

namespace Assets.Levels
{
    public class Level2 : ILevel
    {
        public void Start()
        {
            Physics.gravity = new Vector3(0, -19, 0);
            cMoveBird.Speed = cMoveBird.Speed * 3;
        }

        public void Reset()
        {
            Physics.gravity = new Vector3(0, 0, 0);
            cMoveBird.Speed = cMoveBird.Speed / 3;
        }
    }
}
