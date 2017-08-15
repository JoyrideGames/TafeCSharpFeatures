using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid2DMovement : MonoBehaviour {

    public float movementSpeed = 20f, rotationSpeed = 20f, deceleration = 10f;

    private Rigidbody2D rigid2D;
	// Use this for initialization
	void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


        Movement();
        Decelerate();
        Rotation();
   

	}
    void Decelerate()
    {
        rigid2D.velocity += -rigid2D.velocity * deceleration * Time.deltaTime;
    }
    void Movement()
    {
        float moveVertical = Input.GetAxis("Vertical");
        rigid2D.AddForce(transform.right * moveVertical * movementSpeed);



    }
    void Rotation()

    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.rotation *= Quaternion.AngleAxis(moveHorizontal * rotationSpeed * Time.deltaTime, Vector3.back * moveVertical);
    }
}
