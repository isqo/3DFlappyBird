using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Score : MonoBehaviour
    {
        public Text ScoreText;
        public static float points = 0;

        void start()
        {
        }
   
        void Update()
        {
            ScoreText.text = "Score: "+ points.ToString();
        }
    }
}
