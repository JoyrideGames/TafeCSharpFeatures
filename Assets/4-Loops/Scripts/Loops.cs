using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LoopsArrays
{
    public class Loops : MonoBehaviour
    {
        private float timer = 0f;
        public float printTime = 2f;
        public GameObject[] spawnPrefabs;
        public float spawnRadius = 5f;
        public int spawnAmount = 10;
        public float frequency = 3f;
        public float amplitude = 6f;

        void Start()
        {
          
                SpawnObjectsWithSine();
         
        }


        void Update()
        {
           // while (timer <= printTime)
           // {
           //     timer += Time.deltaTime;
           //     print("Put the cookie down");
           // }
        }

       void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, spawnRadius);
        }

        void SpawnObjectsWithSine()
        {
            /*
             for (initilization; condition; iteration)
             {
                 // Statement(s)
             }

           */

            for (int i = 0; i < spawnAmount; i++)
            {
                //Spawned new gameobject
                int randomIndex = Random.Range(0, spawnPrefabs.Length);
                //Store randomly selected prefa
                GameObject randomPrefab = spawnPrefabs[randomIndex];
                //Instantiate randomly selected prefab
                GameObject clone = Instantiate(randomPrefab);
                //    GameObject clone = Instantiate(spawnPrefabs[0]);    <--- To choose one array
                //Grab the mesh renderer
                Renderer rend = clone.GetComponent<Renderer>();
                //Changes the color
                float r = Random.Range(0, 2);
                float g = Random.Range(0, 2);
                float b = Random.Range(0, 2);
                
                //Alpha (transparentcy)
                float a = 1;
                rend.material.color = new Color(r, g, b, a);      //Multicolor
               // rend.sharedMaterial.color = new Color(r, g, b, a);     //Single Color

                // Generate random position within circle (sphere)
                float x = Mathf.Sin(i * frequency) * amplitude;
                float y = i;
               // float z = 0;
                float z = Mathf.Cos(i * frequency) * amplitude;
                Vector3 randomPos = transform.position + new Vector3(x, y, z);
                //cancels out the z
                //randomPos.z = 0;
                //Set spawned object's position
                clone.transform.position = randomPos;
                
            }
        }


        void SpawnObjects()
        {
            /*
              for (initilization; condition; iteration)
              {
                  // Statement(s)
              }

            */

            for (int i = 0; i < spawnAmount; i++)
            {
                GameObject clone = Instantiate(spawnPrefabs[0]);
                Vector3 randomPos = transform.position + Random.insideUnitSphere * spawnRadius;
                //cancels out the z
                randomPos.z = 0;
                //Set spawned object's position
                clone.transform.position = randomPos;

            }
        }


    } }



#region
/* while (condition)
 * { //Statement }

//infinate loop

int iteration = 0;

while (iteration < 1000)
    {
    //if (Input.GetKeyDown(KeyCode.P))
    //{
        print(message);
        iteration++;
    //}







In update:
* int iteration = 0;
* //infinate loop
* while (iteration < 10) //Stick Around
* { 
* iteration ++;
* if (input.GetKey(KeyCode.Space))
* {
* print("Message");
* break;
* }
* 



/* int iteration = 0;

while (iteration< 1000)
    {
    //if (Input.GetKeyDown(KeyCode.P))
    //{
        print(message);
iteration++;



WORKSish
private float timer = 0f;
public float printTime = 2f;


public string message = "Print This";

void Update()
{

Slaps on 101 consoles messages 2secs in.

time throught untill timer gets to printline
while (timer <= printTime) //Stick around
{
    Count up timer in seconds
    timer += Time.deltaTime;
    print("PUT THE COOKIE DOWN");
}

            }






WORKS! */
#endregion