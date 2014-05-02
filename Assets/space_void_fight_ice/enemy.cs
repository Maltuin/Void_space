using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	private float nextFire;
	public float shootrate;
	public GameObject ice_enemy;
	public static GameObject enemy2;
	public Transform ice_spawn1;
	public Transform ice_spawn2;
	public Transform ice_spawn3;
	public Transform ice_spawn4;
	public Transform ice_spawn5;
	public Transform ice_spawn6;
	public GameObject ice_shoot;
	private GameObject clone_en1;
	// Use this for initialization
	void Start () {
		enemy2 = Instantiate(ice_enemy,new Vector3(2.768367f,0,21.21653f), ice_enemy.transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			int randomNumber = Random.Range (1, 7);
			int pos  = Random.Range (0,10);
			nextFire = Time.time + shootrate;
			if(pos < 2){
				enemy2.transform.position = new Vector3(-2.122988f,0,21.17747f);
			}
			else if(pos < 4){
				enemy2.transform.position = new Vector3(0.9858723f,0,21.17747f);
			}
			else{
				enemy2.transform.position = new Vector3(4.388571f,0,21.17747f);
			}
			if(randomNumber == 1)
				clone_en1 = Instantiate(ice_shoot, ice_spawn1.position, ice_spawn1.rotation) as GameObject;
			else if(randomNumber == 2)
				clone_en1 = Instantiate(ice_shoot, ice_spawn2.position, ice_spawn2.rotation) as GameObject;
			else if(randomNumber == 3)
				clone_en1 = Instantiate(ice_shoot, ice_spawn3.position, ice_spawn3.rotation) as GameObject;
			else if(randomNumber == 4)
				clone_en1 = Instantiate(ice_shoot, ice_spawn4.position, ice_spawn4.rotation) as GameObject;
			else if(randomNumber == 5)
				clone_en1 = Instantiate(ice_shoot, ice_spawn5.position, ice_spawn5.rotation) as GameObject;
			else
				clone_en1 = Instantiate(ice_shoot, ice_spawn6.position, ice_spawn6.rotation) as GameObject;
			Destroy(clone_en1, 2);

		}
	}
}
