using UnityEngine;
using System.Collections;

public class ship_invoke : MonoBehaviour {

	private GameObject ship;
	public GameObject ship1;
	public GameObject ship2;
	// Use this for initialization
	void Start () {
		if (SpaceShip.ship_name == "SciFi_Fighter_AK5") {
			ship = (GameObject)Instantiate (ship1, new Vector3 (-7.262712f, 9.461258f, 28.52121f), transform.rotation);
			ship.transform.localScale = new Vector3 (1f, 1f, 1f);
			}
		else if (SpaceShip.ship_name == "vehicle_enemyShip") {
			ship = (GameObject)Instantiate (ship2, new Vector3 (-7.262712f, 9.461258f, 28.52121f), transform.rotation);
			ship.transform.localScale = new Vector3 (8f, 8f, 8f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
