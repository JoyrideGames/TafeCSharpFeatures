using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {

    private Rigidbody2D spinnySun;
    public int leftSpeed;
    public int rightSpeed;
    // public float moveCounter, moveClock;
    //public float rotationTurretSpeed;

    // Use this for initialization
    void Start()
    {
        spinnySun = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Spin();
    }

    void Spin()
    {

        

        
            transform.Rotate(0, 0, leftSpeed);
      
    }
}




//transform.Rotate(Vector3.forward * rotationspeed * blah blah speed)