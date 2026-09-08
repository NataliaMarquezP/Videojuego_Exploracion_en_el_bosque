using UnityEngine;

public class FinalGoal : MonoBehaviour
{
	private void OnTriggerEnter(Collider otro)
	{
		if (!otro.CompareTag("Player"))
		{
			return;
		}

		Debug.Log("HAS LLEGADO AL FINAL DEL JUEGO!");
		gameObject.SetActive(false);
	}
}