using UnityEngine;
using System.Collections;

public class planet : MonoBehaviour
{
	static public bool fire = false;
	static public bool earth = false;
	static public bool ice = false;
	static public int fire_degat = 10;
	static public int earth_degat = 15;
	static public int ice_degat = 20;
}
public class choose : MonoBehaviour {

	RaycastHit myhit = new RaycastHit ();
	Ray myray = new Ray ();
	public GameObject fire;
	public GameObject ice;
	public GameObject earth;

	void check_do()
	{
		if (planet.fire == true) {
					fire.renderer.material.color = new Color (0, 0, 0, 0);
				}
		else if (planet.fire == true) {
					fire.renderer.material.color = new Color (0, 0, 0, 0);	
				}	
		else if (planet.fire == true) {
				fire.renderer.material.color = new Color(0,0,0,0);	
		}
	}
	// Use this for initialization
		void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		check_do ();
		if (Input.GetKey(KeyCode.Mouse0)){
			myray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (myray,out myhit,100)) {
				print("toot");
				if(myhit.collider.gameObject.name == "fire")
				{
					if (planet.fire == false){
						Application.LoadLevel("space_void_fight");
					}
						print("GO on FIRE");
				}
				else if (myhit.collider.gameObject.name == "earth")
				{
					if (planet.fire == false)
						Application.LoadLevel("");
					print("GO on earth");
				}
				else if (myhit.collider.gameObject.name == "ice")
				{
					if (planet.fire == false)
						Application.LoadLevel("space_void_fight_ice");
					print("GO on ice");
				}
			}
		}
	}
}

