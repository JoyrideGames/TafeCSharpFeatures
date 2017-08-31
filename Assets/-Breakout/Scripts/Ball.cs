using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f;
        public int score = 0;
        public Text scoreText;
        public Text multiText;
        public Text totalText;
        public int amount;
        public int multiC;
        public int calculatingTotal;
        public int total;

        private Vector3 velocity; //Velocity of the ball (Direction X Speed

        public void Scoring(int amount)
        {
            score += amount;
            scoreText.text = "Score: " + score;
        }

        public void Multiply(int multi)
        {
            multiC = 5;
            multiText.text = "Previous Multi: " + multiC;
            Calculating();

        }

        public void MultiplyB(int multiB)
        {
            multiC = 10;
            multiText.text = "Previous Multi: " + multiC;
            Calculating();

        }

        void Calculating()
        {
            calculatingTotal = multiC * score;
            total += calculatingTotal;
            totalText.text = "Total: " + total;
        }

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

            if(score >= 10)
            {
                SceneManager.LoadScene(0);
            }
        }



    }

}