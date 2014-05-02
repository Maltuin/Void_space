using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {
	public GameObject asteroid;
	public int speed;
	public int stop;
	public int i;
	private GameObject toto;

	// Use this for initialization
	void Start () {
				toto = (GameObject)Instantiate (asteroid, new Vector3 (-11.92502f, 7.300119f, 18.78019f), transform.rotation);
		}
	
	// Update is called once per frame
	void Update () {

		if (i < stop){
			toto.transform.Translate(-Time.deltaTime * speed, Time.deltaTime, 0);
		i++;
		}
		else
		{
			Destroy (toto);
			i = 0;
			Start();
		}

	}
}