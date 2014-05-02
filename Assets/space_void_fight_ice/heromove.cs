using UnityEngine;
using System.Collections;

public class heromove : MonoBehaviour {
	private int life2 = SpaceShip.life;
	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		life2 -= planet.ice_degat;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(life2 < 1)
		{
			Destroy (shipmovementfight.controler);
			Application.LoadLevel("menu");
		}
}
}
