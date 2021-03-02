using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{
	void Update()
	{
		if (transform.position.y <= -15) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}