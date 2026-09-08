using UnityEngine;

public class RespawnTrap : MonoBehaviour
{
	[Header("Referencia")]
	[SerializeField] private Transform puntoReaparicion;

	private void OnTriggerEnter(Collider otro)
	{
		if (!otro.CompareTag("Player"))
		{
			return;
		}

		if (puntoReaparicion == null)
		{
			Debug.LogError(
				"Falta asignar el punto de reaparicion."
			);
			return;
		}

		CharacterController controlador =
			otro.GetComponent<CharacterController>();

		if (controlador != null)
		{
			controlador.enabled = false;
		}

		otro.transform.position = puntoReaparicion.position;

		if (controlador != null)
		{
			controlador.enabled = true;
		}

		Debug.Log(
			"Jugador atrapado. Regresando al inicio."
		);
	}
}