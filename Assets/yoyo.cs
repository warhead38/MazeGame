using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoyo : MonoBehaviour {
	int a;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal= Input.GetAxis("Horizontal");
		float moveVertical= Input.GetAxis("Vertical");                                     
		Vector3 force = new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce (force*500.0f*Time.deltaTime);
		if(Input.GetKeyDown(KeyCode.Space)){
                   Vector3 jump = new Vector3 (0.0f,5.0f,0.0f);
                   rb.AddForce (jump, ForceMode.Impulse);
          }
	}
}

