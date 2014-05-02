using UnityEngine;
using System.Collections;

public class SpaceShip : MonoBehaviour
{
	static public string ship_name;
	static public int life;
	static public int exp;
	static public int highp;
	static public int level;
	static public int armor;
	static public string element;
	static public int degat;

}

public class choose_purple : MonoBehaviour {

	RaycastHit myhit = new RaycastHit ();
	Ray myray = new Ray ();


	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0)){
			myray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (myray,out myhit,100)) {
				if(myhit.collider.gameObject.name == "SciFi_Fighter_AK5")
				{
					SpaceShip.ship_name = myhit.collider.gameObject.name;
					SpaceShip.life = 150;
					SpaceShip.exp = 0;
					SpaceShip.highp = SpaceShip.level * 150;
					SpaceShip.level = 1;
					SpaceShip.armor = 50;
					SpaceShip.element = "ice";
					SpaceShip.degat = 10;
					Application.LoadLevel ("space_void_transition");
				}
				else if (myhit.collider.gameObject.name == "vehicle_enemyShip")
				{
					SpaceShip.ship_name = myhit.collider.gameObject.name;
					SpaceShip.life = 300;
					SpaceShip.exp = 0;
					SpaceShip.highp = SpaceShip.level * 150;
					SpaceShip.level = 1;
					SpaceShip.armor = 60;
					SpaceShip.element = "earth";
					SpaceShip.degat = 5;
					Application.LoadLevel ("space_void_transition");
				}
			}
		}
	}
}