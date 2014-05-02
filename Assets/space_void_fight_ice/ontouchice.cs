using UnityEngine;
using System.Collections;

public class ontouchice : MonoBehaviour {
	public int enlife;
	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		enlife -= SpaceShip.degat;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(enlife < 1)
		{
			Destroy (touchenemy.enemy2);
			planet.ice = true;
			Application.LoadLevel("planet");
		}
	}
}
