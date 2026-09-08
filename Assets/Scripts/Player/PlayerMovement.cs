using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
	[Header("Movimiento")]
	[SerializeField] private float velocidadCaminar = 4f;
	[SerializeField] private float velocidadCorrer = 7f;
	[SerializeField] private float velocidadGiro = 12f;

	[Header("Salto y gravedad")]
	[SerializeField] private float alturaSalto = 1.5f;
	[SerializeField] private float gravedad = -20f;

	[Header("Camara")]
	[SerializeField] private Transform camaraPrincipal;

	private CharacterController controlador;
	private float velocidadVertical;

	private void Awake()
	{
		controlador = GetComponent<CharacterController>();
	}

	private void Update()
	{
		Mover();
	}

	private void Mover()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");

		Vector3 entrada = new Vector3(horizontal, 0f, vertical).normalized;

		float velocidadActual = Input.GetKey(KeyCode.LeftShift)
			? velocidadCorrer
			: velocidadCaminar;

		if (entrada.sqrMagnitude > 0.01f)
		{
			float anguloCamara = camaraPrincipal != null
				? camaraPrincipal.eulerAngles.y
				: 0f;

			float anguloObjetivo =
				Mathf.Atan2(entrada.x, entrada.z) * Mathf.Rad2Deg
				+ anguloCamara;

			Quaternion rotacionObjetivo =
				Quaternion.Euler(0f, anguloObjetivo, 0f);

			transform.rotation = Quaternion.Slerp(
				transform.rotation,
				rotacionObjetivo,
				velocidadGiro * Time.deltaTime
			);

			Vector3 direccion =
				Quaternion.Euler(0f, anguloObjetivo, 0f)
				* Vector3.forward;

			controlador.Move(
				direccion.normalized
				* velocidadActual
				* Time.deltaTime
			);
		}

		if (controlador.isGrounded && velocidadVertical < 0f)
		{
			velocidadVertical = -2f;
		}

		if (controlador.isGrounded &&
			Input.GetKeyDown(KeyCode.Space))
		{
			velocidadVertical = Mathf.Sqrt(
				alturaSalto * -2f * gravedad
			);
		}

		velocidadVertical += gravedad * Time.deltaTime;

		controlador.Move(
			Vector3.up * velocidadVertical * Time.deltaTime
		);
	}
}