using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class cMoveCamera : MonoBehaviour
    {
        public float lookSensitivity = 2.0f;
        public float BehindThePlayerZAxis = -2.0f;
        private float yRotation;
        private float xRotation;

        void Update()
        {
            if (Input.GetMouseButton(1))
            {
                yRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
                xRotation += Input.GetAxis("Mouse X") * lookSensitivity;
                gameObject.transform.rotation = Quaternion.Euler(yRotation, xRotation, BehindThePlayerZAxis);
            }
            else if (Input.GetMouseButtonUp(1))
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, BehindThePlayerZAxis);
            }
        }
    }
}
