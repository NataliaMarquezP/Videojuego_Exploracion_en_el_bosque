using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
	[Header("Referencias")]
	[SerializeField] private Transform jugador;
	[SerializeField] private GameObject cofreCerrado;
	[SerializeField] private GameObject cofreAbierto;

	[Header("Interaccion")]
	[SerializeField] private float distanciaInteraccion = 5f;

	private bool abierto;

	private void Start()
	{
		Debug.Log("ChestInteraction iniciado correctamente.");

		if (jugador == null ||
			cofreCerrado == null ||
			cofreAbierto == null)
		{
			Debug.LogError(
				"Falta asignar una referencia en ChestInteraction."
			);

			enabled = false;
			return;
		}

		cofreCerrado.SetActive(true);
		cofreAbierto.SetActive(false);
	}

	private void Update()
	{
		if (abierto)
		{
			return;
		}

		float distancia = Vector3.Distance(
			cofreCerrado.transform.position,
			jugador.position
		);

		if (Input.GetKeyDown(KeyCode.E))
		{
			Debug.Log(
				"E detectada. Distancia al cofre: " + distancia
			);

			if (distancia <= distanciaInteraccion)
			{
				AbrirCofre();
			}
			else
			{
				Debug.Log(
					"El Player esta demasiado lejos del cofre."
				);
			}
		}
	}

	private void AbrirCofre()
	{
		abierto = true;

		cofreCerrado.SetActive(false);
		cofreAbierto.SetActive(true);

		Debug.Log("COFRE ABIERTO CORRECTAMENTE");
	}
}
