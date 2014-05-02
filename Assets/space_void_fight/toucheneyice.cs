using UnityEngine;
using System.Collections;

public class toucheneyice : MonoBehaviour {
	private float nextFire;
	public float shootrate;
	public GameObject enemy;
	public static GameObject enemy2;
	// Use this for initialization
	void Start () {
		enemy2 = Instantiate(enemy,new Vector3(3,0,21), enemy.transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
