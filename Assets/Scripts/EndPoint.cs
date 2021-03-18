using UnityEngine;
using UnityEngine.SceneManagement

public class EndPoint : MonoBehaviour
{
	public LevelExit levelExit; // Import reference to "key" object

	void OnTriggerEnter() // Run function when player touches the exit console
	{
		if (levelExit.hasKey == true) // Test if the player has collected the exit key
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the level when the player beats it
			Debug.Log("Exit!"); 
		}
	}
}