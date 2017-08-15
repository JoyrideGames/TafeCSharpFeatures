using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{
    public class Shooting : MonoBehaviour
    {

        public GameObject projectilePrefab;
        //public GameObject[] projectileClone;
        //public Transform[] spwanLoctions;
        public float projectileSpeed = 10f;
        public float shootRate = 0.1f;
        private float shootTimer = 0f;


        
        // Update is called once per frame
        void Update()
        {
            //countup in seconds
            shootTimer += Time.deltaTime;
           

         //   if (Input.GetKey.Space) &shootTimer >= shootRate;
           // {
             //   projectileClone[0] = Instantiate(projectilePrefab[0] as GameObject); //spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
               // projectileClone[1] = Instantiate(projectilePrefab[1]); spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0) as GameObject;


            if (Input.GetKey(KeyCode.Space) && shootTimer >= shootRate)
            {
                GameObject bullet = Instantiate(projectilePrefab, transform.position, Quaternion.identity) as GameObject;
                bullet.GetComponent<Rigidbody2D>().AddForce(transform.forward * 10);
                //reset shootTimer = 0;
            }
                
        }
       // void Shoot()
       // {
       //     GameObject projectile = Instantiate(projectilePrefab) as GameObject;
           // var bullet = (new GameObject)Instantiate (
             //   projectilePrefab)
                
       // }          
         
        //}
            //if space is pressed AND shoottimer >= shootRate
              //call shoot()
              //RESET shootTimer = 0
      //}
    }
}