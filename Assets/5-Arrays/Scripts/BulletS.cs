using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraysTwo
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BulletS : MonoBehaviour
    {
        public float speed = 10f;
        public Vector2 direction;

        // Update is called once per frame
        void Update()
        {
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }
}