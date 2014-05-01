using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		rigidbody.velocity = new Vector3(speed, 0, 0);
	}
}
