using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	// use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Upadate is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody> ().AddForce (movement * speed * Time.deltaTime);
//		rb.AddForce (movement * speed);
	}
}