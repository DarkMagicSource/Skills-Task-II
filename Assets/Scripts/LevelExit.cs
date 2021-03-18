using UnityEngine;

public class LevelExit : MonoBehaviour
{
	public bool hasKey = false; // Set a reference to whether the player has collected the key

	void OnTriggerEnter() // Run function when the player touches the key
	{
		if (hasKey == false) // Testi f the palyer has previously colelcted the key
		{
			hasKey = true; // Give the player the key
			Debug.Log("Key got!");
		}
	}
}