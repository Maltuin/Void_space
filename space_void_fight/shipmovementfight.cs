using UnityEngine;
using System.Collections;

public class shipmovementfight : MonoBehaviour {
	private GameObject controler;
	public GameObject controler1;
	public GameObject controler2;
	public int ship;
	// Use this for initialization
	void Start () {
		if (ship == 1) {
			controler = (GameObject)Instantiate (controler1, new Vector3 (-51.22791f, 0.6604357f, -0.3738514f), transform.rotation);
			controler.transform.eulerAngles = new Vector3 (0, 90, -90);
		} else if (ship == 2) {
			controler = (GameObject)Instantiate (controler2, new Vector3(-56.32072f,-0.3880819f,-1.104746f), transform.rotation);
			controler.transform.eulerAngles = new Vector3 (0, 90, 90);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
