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
				if (ship == 1) {
						controler = (GameObject)Instantiate (controler1, new Vector3 (-18.69715f, 7.855296f, -42.20232f), transform.rotation);
						controler.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
						controler.transform.eulerAngles = new Vector3 (11, 70, 0);
				} else if (ship == 2) {
						controler = (GameObject)Instantiate (controler2, new Vector3(-20.69715f,8.855296f,-42.20232f), transform.rotation);
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
		}
}