﻿using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
