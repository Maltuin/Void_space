﻿using UnityEngine;
using System.Collections;

public class killtrig : MonoBehaviour {
	void OnTriggerExit(Collider other){
		Destroy (other.gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
