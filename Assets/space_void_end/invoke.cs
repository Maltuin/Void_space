using UnityEngine;
using System.Collections;

public class invoke : MonoBehaviour {

	private GameObject controler;
	public GameObject ship;
	public GameObject ship1;
	// Use this for initialization
	void Start () {
				if (SpaceShip.ship_name == "SciFi_Fighter_AK5") {
						controler = (GameObject)Instantiate (ship, new Vector3 (-2.569092f, 1.152004f, -25.71315f), transform.rotation);
			controler.transform.Rotate(19.72954f, 137.2352f, 354.5966f);		
		} 
		else if (SpaceShip.ship_name == "vehicle_enemyShip") {
						controler = (GameObject)Instantiate (ship1, new Vector3 (-2.569092f, 1.152004f, -25.71315f), transform.rotation);
		                                               
				}
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
