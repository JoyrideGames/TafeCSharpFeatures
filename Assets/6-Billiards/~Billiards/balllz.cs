using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balllz : MonoBehaviour {

    public float gravity = -9.81f;
    public Rigidbody rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rigid.velocity = rigid.velocity.normalized + Vector3.back * gravity;
	}
}
