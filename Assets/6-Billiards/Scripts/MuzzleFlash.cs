using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Collisions
{


    public class MuzzleFlash : MonoBehaviour
    {
        public int maxFrame = 1;

        private int currenFrames = 0;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            if(currenFrames >= maxFrame)
            {
           //     destroy(gameObject);
            }
           // currentFrames++;

        }
    }
}