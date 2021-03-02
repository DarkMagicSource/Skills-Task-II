using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 10f;
	private Rigidbody rb;

	void Start()
	{
		rb = gameObject.GetComponent<Rigidbody>();
		rb.velocity = transform.forward * speed;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag != "Player") {
			Destroy(gameObject);
		}
	}
}