using UnityEngine;
using System.Collections;

public class touchenemy : MonoBehaviour {
	public Transform sh_enemy1;
	public GameObject enshoot;
	public Transform sh_enemy2;
	public GameObject enshoot2;
	public Transform sh_enemy3;
	public GameObject enshoot3;
	public Transform sh_enemy1_2;
	public Transform sh_enemy1_1;
	public Transform sh_enemy2_1;
	public Transform sh_enemy2_2;
	public Transform sh_enemy3_1;
	public Transform sh_enemy3_2;
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
		if (Time.time > nextFire) {
						int randomNumber = Random.Range (0, 3);
						if (randomNumber == 0) {
								enemy2.transform.position = new Vector3 (1, 0, 22);
				nextFire = Time.time + shootrate;
				GameObject clone_en = Instantiate(enshoot, sh_enemy1.position, sh_enemy1.rotation) as GameObject;
				GameObject clone_en2 = Instantiate(enshoot2, sh_enemy2.position, sh_enemy2.rotation) as GameObject;
				GameObject clone_en3 = Instantiate(enshoot3, sh_enemy3.position, sh_enemy3.rotation) as GameObject;
				Destroy(clone_en, 2);
				Destroy(clone_en2, 2);
				Destroy(clone_en3, 2);
						}
						if (randomNumber == 1) {
								enemy2.transform.position = new Vector3 (3, 0, 22);
				nextFire = Time.time + shootrate;
				GameObject clone_en = Instantiate(enshoot, sh_enemy1_1.position, sh_enemy1_1.rotation) as GameObject;
				GameObject clone_en2 = Instantiate(enshoot2, sh_enemy2_1.position, sh_enemy2_1.rotation) as GameObject;
				GameObject clone_en3 = Instantiate(enshoot3, sh_enemy3_1.position, sh_enemy3_1.rotation) as GameObject;
				Destroy(clone_en, 2);
				Destroy(clone_en2, 2);
				Destroy(clone_en3, 2);
						}
						if (randomNumber == 2) {
								enemy2.transform.position = new Vector3 (5, 0, 22);
				nextFire = Time.time + shootrate;
				GameObject clone_en = Instantiate(enshoot, sh_enemy1_2.position, sh_enemy1_2.rotation) as GameObject;
				GameObject clone_en2 = Instantiate(enshoot2, sh_enemy2_2.position, sh_enemy2_2.rotation) as GameObject;
				GameObject clone_en3 = Instantiate(enshoot3, sh_enemy3_2.position, sh_enemy3_2.rotation) as GameObject;
				Destroy(clone_en, 2);
				Destroy(clone_en2, 2);
				Destroy(clone_en3, 2);
						}
				}
	}
}
