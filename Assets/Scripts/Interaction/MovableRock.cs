using UnityEngine;

public class MovableRock : MonoBehaviour
{
	[Header("Referencias")]
	[SerializeField] private Transform jugador;
	[SerializeField] private Transform puntoFinal;
	[SerializeField] private Collider colliderRoca;

	[Header("Configuracion")]
	[SerializeField] private float distanciaInteraccion = 8f;
	[SerializeField] private float velocidadMovimiento = 3f;

	private bool debeMoverse = false;
	private bool movimientoTerminado = false;

	private void Update()
	{
		if (jugador == null ||
			puntoFinal == null ||
			colliderRoca == null)
		{
			return;
		}

		if (!debeMoverse && !movimientoTerminado)
		{
			Vector3 puntoCercano =
				colliderRoca.ClosestPoint(jugador.position);

			float distancia = Vector3.Distance(
				jugador.position,
				puntoCercano
			);

			if (Input.GetKeyDown(KeyCode.F))
			{
				Debug.Log(
					"F detectada. Distancia a la superficie: "
					+ distancia
				);

				if (distancia <= distanciaInteraccion)
				{
					debeMoverse = true;
					Debug.Log("La roca comienza a moverse.");
				}
				else
				{
					Debug.Log("Acercate mas a la roca.");
				}
			}
		}

		if (debeMoverse && !movimientoTerminado)
		{
			transform.position = Vector3.MoveTowards(
				transform.position,
				puntoFinal.position,
				velocidadMovimiento * Time.deltaTime
			);

			if (Vector3.Distance(
				transform.position,
				puntoFinal.position
			) < 0.05f)
			{
				transform.position = puntoFinal.position;
				debeMoverse = false;
				movimientoTerminado = true;

				Debug.Log("Pasadizo desbloqueado.");
			}
		}
	}
}