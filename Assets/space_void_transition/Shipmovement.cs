using UnityEngine;
using System.Collections;
 

public class Shipmovement : MonoBehaviour
{
		public float speed;
		public int stop;
		public int i;
		private GameObject controler;
		public GameObject controler1;
		public GameObject controler2;
		public int ship;

		

		void Start ()
		{
		if (SpaceShip.ship_name == "SciFi_Fighter_AK5") {
			controler = (GameObject)Instantiate (controler1, new Vector3 (-12.6995f, 7.928557f, -25.29178f), transform.rotation);
						controler.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
						controler.transform.eulerAngles = new Vector3 (11, 70, 0);
		} else if (SpaceShip.ship_name == "vehicle_enemyShip") {
			controler = (GameObject)Instantiate (controler2, new Vector3(-12.6995f, 7.928557f,-25.29178f), transform.rotation);
						controler.transform.localScale = new Vector3 (1, 1, 1);
						controler.transform.eulerAngles = new Vector3 (20, 90, 0);
						speed -=2;
				}

		}
		
		// Update is called once per frame
		void Update ()
		{
				if (i < stop) {
						controler.transform.position += controler.transform.forward * speed * Time.deltaTime;
						i++;
				}
				else {
					Application.LoadLevel("planet");
			}
		}
}