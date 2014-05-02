using UnityEngine;
using System.Collections;

public class ontouchhero : MonoBehaviour {
	public int life;
	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		life -= planet.fire_degat;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(life < 1)
		{
			Destroy (shipmovementfight.controler);
			Application.LoadLevel("menu");
		}
	}
}
