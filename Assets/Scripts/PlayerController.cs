using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody PlayerRb;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		if (Input.GetKey("up")) {
			PlayerRb.AddForce(0 ,0 ,speed * Time.deltaTime);
		}
		if (Input.GetKey("down")) {
			PlayerRb.AddForce(0 ,0 ,-speed * Time.deltaTime);
		}
		if (Input.GetKey("left")) {
			PlayerRb.AddForce(-speed * Time.deltaTime ,0 ,0);
		}
		if (Input.GetKey("right")) {
			PlayerRb.AddForce(speed * Time.deltaTime ,0 ,0);
		}
	}
}
