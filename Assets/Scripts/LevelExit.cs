using UnityEngine;

public class LevelExit : MonoBehaviour
{
	public bool hasKey = false;

	void OnTriggerEnter()
	{
		if (hasKey == false)
		{
			hasKey = true;
			Debug.Log("Key got!");
		}
	}
}