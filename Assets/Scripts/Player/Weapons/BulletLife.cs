using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
	public float lifeTime = 1f;

	void Start()
	{ 
		StartCoroutine(BulletLifeCycle()); 
	}

	IEnumerator BulletLifeCycle()
	{
		Debug.Log("Bullet Timer started");
		yield return new WaitForSeconds(lifeTime); // Wait from timer ot expire
		Destroy(gameObject); // Destroy bullet object after timer has completed
		Debug.Log("Bullet Timer finished");
	}
}