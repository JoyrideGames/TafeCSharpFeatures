using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Billiards
{
    public class PocketS : MonoBehaviour
    {

        public int score = 0;
        public Text scoreText;

        void OnCollisionEnter(Collision col)
        {
            Destroy(col.gameObject);
            score++;
            scoreText.text = "Score: " + score;


           
        }



    }
}