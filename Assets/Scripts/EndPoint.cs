using UnityEngine;

public class EndPoint : MonoBehaviour
{
	public LevelExit levelExit;

	void OnTriggerEnter()
	{
		if (levelExit.hasKey == true)
		{
			Debug.Log("Exit!");
		}
	}
}