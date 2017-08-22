using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f;

        private Vector3 velocity; //Velocity of the ball (Direction X Speed


        public void Fire(Vector3 direction)
        {
            velocity = direction * speed;
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            //Grab contact point of collision
            ContactPoint2D contact = col.contacts[0];
            //Calculate the reflection point of the ball using the velocity & contact normal
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            //Calculate new velocity for reflection multiply by the same speed (velocity.magnitude)
            velocity = reflect.normalized * velocity.magnitude;
        }

        private void Update()
        {
            //Move ball using velocity & deltaTime
            transform.position += velocity * Time.deltaTime;
        }



    }

}