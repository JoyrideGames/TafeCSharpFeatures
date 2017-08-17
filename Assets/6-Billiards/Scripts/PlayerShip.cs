using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Collisions
{
    //Rigidbody2D[] colliders = FindObjectsOfType<Rigidbody2D>();

    //In fixed update!!!       
    //physics.OverLapSphereAll()      <-grab all objects in sphere.

    public class PlayerShip : MonoBehaviour
    {
        public float acceleration = 50f;
        public float rotationSpeed = 360f;
        public float gottaGoFast = 150f;
        
        private Rigidbody2D rigid;


        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            Accelerate();
            Rotate();
        }

        void Accelerate()
        {
            float inputV = Input.GetAxis("Vertical");
            float currentSpeed = acceleration;
            //rigid.AddForce(transform.up * inputV * acceleration);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                currentSpeed = gottaGoFast;
            }
            rigid.AddForce(transform.up * inputV * currentSpeed);
        }

        void Rotate()
        {
            float inputH = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.back, rotationSpeed * inputH * Time.deltaTime);

        }
    }
}





