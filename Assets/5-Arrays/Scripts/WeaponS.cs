using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraysTwo
{

    public class WeaponS : MonoBehaviour
    {
        public int damage = 10;
        public int maxBullets = 30;
        public float fireInterval = 0.2f;
        public GameObject bulletPrefab;
        public Transform spawnPoint;

        private Transform target;
        private bool isFired = false;
        private int currentBullets = 0;

        //Array
        private BulletS[] spawnedBullets;  //null by default


        // Use this for initialization
        void Start()
        {
            spawnedBullets = new BulletS[maxBullets];
        }

        // Update is called once per frame
        void Update()
        {
            //if !isFired && currentBullets < maxBullets
            if(!isFired && currentBullets < maxBullets)
            {
                //Fire!
                StartCoroutine(Fire());
            }
        }

        IEnumerator Fire()
        {
            //Run whatever is at the top of this function
            isFired = true;

            //Spawn a bullet
            SpawnBullet();

            yield return new WaitForSeconds(fireInterval); //wait for fire interval to finish

            //Run whatever is here after fireInterval
            isFired = false;

        }
        void SpawnBullet()
        {
            //1. Instantiate a bullet cloan
            GameObject cloan = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
            //2. Create direction variable for bullet and rotating
            Vector2 direction = target.position - target.position;
            //Then normalize number for later
            direction.Normalize();
            //3. Rotate the weapon to direction
            transform.rotation = Quaternion.LookRotation(direction);
            //4. Grab the bullet script from cloan
            BulletS bullet = cloan.GetComponent<BulletS>();
            //5. Send bullet to target (by setting direction)
            bullet.direction = direction;
            //6. Store bullet in array, using currentBullets as index
            spawnedBullets[currentBullets] = bullet;
            //7. Count up currentBullets
            currentBullets++;

        }

        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }

}





///spwanTimer += Time.deltaTime;
///if(fireTimer >= fireInterval)
///{SpawnBullet();