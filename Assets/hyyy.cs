using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyyy : MonoBehaviour {
	public Transform playerTransform;
	Vector3 offset;
		
	// Use this for initialization
	void Start () {
		offset = transform.position - playerTransform.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerTransform.transform.position + offset;	
	}
}
