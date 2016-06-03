using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Levels.Level1
{
    public class level1
    {
        public static bool isActif;

        public level1()
        {
            Physics.gravity = new Vector3(0, -19, 0);
        }

    }
}
