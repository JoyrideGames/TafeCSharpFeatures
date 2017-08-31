using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class blockdestroyB : MonoBehaviour
    {
        public int multi = 10;
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
            
            col.gameObject.GetComponent<Ball>().Scoring (score);
            col.gameObject.GetComponent<Ball>().MultiplyB (multi);
            Destroy(gameObject);
        }

    }
}