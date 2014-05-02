using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

	public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Time.deltaTime, Time.deltaTime * speed,  Time.deltaTime * speed);
	}
}
