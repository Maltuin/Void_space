using UnityEngine;
using System.Collections;

public class ontouch : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		enlife -= 1;
	}
	public int enlife;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(enlife < 1)
		{
		 Destroy (touchenemy.enemy2);
	}
}
}
