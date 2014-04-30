using UnityEngine;
using System.Collections;

public class shipmovementfight : MonoBehaviour {
	private GameObject controler;
	public GameObject controler1;
	public GameObject controler2;
	public GameObject fire1;
	public Transform fire1spawn;
	public float Rate = 0.5f;
	private float nextFire = 0f;
    public int ship;
	// Use this for initialization
	void Start () {
		if (ship == 1) {
			controler = (GameObject)Instantiate (controler1, new Vector3 (-51.22791f, 0.6604357f, -0.3738514f), transform.rotation);
			controler.transform.eulerAngles = new Vector3 (0, 90, -90);
			Instantiate(fire1, fire1spawn.transform.position, fire1spawn.transform.rotation);

		} else if (ship == 2) {
			controler = (GameObject)Instantiate (controler2, new Vector3(-56.32072f,-0.3880819f,-1.104746f), transform.rotation);
			controler.transform.eulerAngles = new Vector3 (0, 90, 90);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			nextFire = Time.time + Rate;
						GameObject clone = Instantiate (fire1, fire1spawn.position, fire1spawn.rotation) as GameObject;
				}
		if (Input.GetKey ("up")) {
			controler.transform.Translate((Time.deltaTime*25),0,0);	
		}
		if (Input.GetKey ("down")) {
						controler.transform.Translate (-(Time.deltaTime*25), 0, 0);
				}
	}
}
