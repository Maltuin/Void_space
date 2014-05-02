using UnityEngine;
using System.Collections;

public class Asteroid1 : MonoBehaviour {
	public GameObject asteroid;
	public int speed;
	public int stop;
	public int i;
	private GameObject toto;

	// Use this for initialization
	void Start () {
		toto = (GameObject)Instantiate (asteroid, new Vector3 (17.77672f, -7f, 12.12134f), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		if (i < stop) {
				toto.transform.Translate (0, 0, Time.deltaTime * speed);
				i++;
				}
		else
		{
			Destroy(toto);
			i = 0;
			Start();
		}
	}
}
