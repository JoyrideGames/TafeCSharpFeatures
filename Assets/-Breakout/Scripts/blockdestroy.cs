using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class blockdestroy : MonoBehaviour
    {
        public int multi = 5;
        public int score = 1;

        // Use this for initialization
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnCollisionEnter2D(Collision2D col)
        {
            Ball ball = col.gameObject.GetComponent<Ball>();
            ball.Scoring (score);
            col.gameObject.GetComponent<Ball>().Multiply (multi);
            Destroy(gameObject);
        }

    }
}