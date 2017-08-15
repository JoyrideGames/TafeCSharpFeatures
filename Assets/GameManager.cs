using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{

    public class GameManager : MonoBehaviour
    {
        public int width = 20;
        public int height = 20;
        public Vector2 spacing = new Vector2(25f, 10f);
        public Vector2 offset = new Vector2(-25f, 0f);
        public GameObject[] blockPrefabs;
        [Header("Debug")]
        public bool isDebugging = false;


        private GameObject[,] spawnnedBlocks;

        void Start()
        {
            GenerateBlocks();
        }

        //  GameObject GetBlockByIndex(int index)
        //  {
        //      //Error handling
        //      if (index > blockPrefabs.Length || index < 0)
        //          return null;
        //      //Create new block at given index
        //      GameObject cloan = Instantiate(blockPrefabs[index]);
        //      //and return it
        //      return cloan
        // }


        GameObject GetRandomBlock()
        {
            //RANDOMLY spawn a new gameobject
            int randomIndex = Random.Range(0, blockPrefabs.Length);
            GameObject randomPrefab = blockPrefabs[randomIndex];
            GameObject clone = Instantiate(randomPrefab);
            // ... and return it
            return clone;
        }



        void GenerateBlocks()
        {

            spawnnedBlocks = new GameObject[width, height];


            // Loop through the width
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //Creat new instance of the block
                    GameObject block = GetRandomBlock();
                    //Set the new position
                    Vector2 pos = new Vector3(x * spacing.x,
                                              y * spacing.y);
                    block.transform.position = pos;
                    //add spawnned blocks to array
                    spawnnedBlocks[x, y] = block;
                }
            }
        }

        void UpdateBlocks()
        {
            // Loop through the entire 2D array
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //Update Positions
                    GameObject currentBlock = spawnnedBlocks[x, y];
                    //Create a new position
                    Vector2 pos = new Vector2(x * spacing.x,
                                              y * spacing.y);
                    //Add an offset to pos
                    pos += offset;
                    //Set currentBlocks position to the new pos
                    currentBlock.transform.position = pos;

                }
            }
        }
        // Update is called once per frame
        void Update()
        {
            if (isDebugging)
            {
                UpdateBlocks();
            }
        }
    }
}
