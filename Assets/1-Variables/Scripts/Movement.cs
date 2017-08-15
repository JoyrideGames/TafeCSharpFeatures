using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Variables
{
    // Clean Code: CTRL+K+D

    public class Movement : MonoBehaviour
    {

        public float movementSpeed = 20f;
        public float rotationSpeed = 20f;
        public float rotateMove;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");
            rotateMove = (inputH * rotationSpeed);

            Vector3 velocity = new Vector3(0, inputV * movementSpeed);
            transform.Translate(velocity * Time.deltaTime);


            Vector3 forward = new Vector3(0, 0, -rotateMove * inputV);
            transform.Rotate(forward * Time.deltaTime);





        }
    }

}