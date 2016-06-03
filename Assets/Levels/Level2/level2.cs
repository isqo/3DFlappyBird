using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Levels.Level2
{
    public class level2
    {
        public static bool isActif;
        public level2()
        {
            Physics.gravity = new Vector3(0, -19, 0);
            cMoveBird.Speed = cMoveBird.Speed * 3;
        }

    }
}
