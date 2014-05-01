using UnityEngine;
using System.Collections;

public class shipmovementfight : MonoBehaviour {
	static public GameObject controler;
	public GameObject controler1;
	public GameObject controler2;
	public Transform shootspawn;
	public GameObject shoot;
	public Transform shootspawn2;
	public GameObject shoot2;
	public Transform shootspawn3;
	public GameObject shoot3;
    private float nextFire;
	public float shootrate;
    public int ship;
	// Use this for initialization
	void Start () {
		if (ship == 1) {
			controler = (GameObject)Instantiate (controler1, new Vector3 (0,0,0), transform.rotation);
			controler.transform.eulerAngles = new Vector3 (0, 0, 0);

		} else if (ship == 2) {
			controler = (GameObject)Instantiate (controler2, new Vector3(0,0,0), transform.rotation);
			controler.transform.eulerAngles = new Vector3 (0, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up") && (controler.transform.position.x - Time.deltaTime*15) > -5.3f) {
			controler.transform.Translate(-(Time.deltaTime*15),0,0);
			shootspawn.Translate(-Time.deltaTime*15,0,0);
			shootspawn2.Translate(-Time.deltaTime*15,0,0);
			shootspawn3.Translate(-Time.deltaTime*15,0,0);
		}
		if (Input.GetKey ("down") && (controler.transform.position.x + Time.deltaTime*15) < 4.5f) {
			controler.transform.Translate ((Time.deltaTime*15), 0, 0);
			shootspawn.Translate(Time.deltaTime*15,0,0);
			shootspawn2.Translate(Time.deltaTime*15,0,0);
			shootspawn3.Translate(Time.deltaTime*15,0,0);
        }
		if(Time.time > nextFire){
			nextFire = Time.time + shootrate;
			GameObject clone = Instantiate(shoot, shootspawn.position, shootspawn.rotation) as GameObject;
			GameObject clone2 = Instantiate(shoot2, shootspawn2.position, shootspawn2.rotation) as GameObject;
			GameObject clone3 = Instantiate(shoot3, shootspawn3.position, shootspawn3.rotation) as GameObject;
			Destroy(clone, 2);
			Destroy(clone2, 2);
			Destroy(clone3, 2);
		}
	}
}
