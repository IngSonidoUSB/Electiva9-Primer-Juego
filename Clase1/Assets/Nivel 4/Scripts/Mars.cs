using UnityEngine;
using System.Collections;
using System;

public class Mars : MonoBehaviour {

	// Variables Publicas
	public GameObject[] HitosPatronMovimiento;
	public float[] VelocidadesPatronMovimiento;

	// variables privadas 
	private Transform thisTransform;
	//private Rigidbody thisRigidbody;
	private int HitoSiguiente = 0;

	// Properties
	// Nos indicará si el objeto puede continuar hacia el siguiente hito del patrón definido
	public bool CanGoToNextMilestone { get; set; }

	void Start () {
		thisTransform = transform;
		//thisRigidbody = GetComponentInParent<Rigidbody>();
		CanGoToNextMilestone = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		// Calculamos la velocidad hacia el siguiente hito (si no hubiese velocidad definida para
		// alguno de los hitos, asumiremos que es 0 y por tanto el objeto quedará parado)
		float VelocidadHaciaHito = 0;
		try
		{
			VelocidadHaciaHito = VelocidadesPatronMovimiento[HitoSiguiente];
		}
		catch
		{
			VelocidadHaciaHito = 0;
		}

		// Comprobamos si podemos ir hacia el siguiente hito
		if (CanGoToNextMilestone)
		{
			try
			{
				// Movemos al objeto hacia el siguiente hito
				if(IrHaciaHito(HitosPatronMovimiento[HitoSiguiente].transform.position, VelocidadHaciaHito))
				{
					// Justo cuando lleguemos a un hito, paramos al objeto
					CanGoToNextMilestone = false;

					// Activamos el/los script/s de comportamiento correspondiente/s al hito actual (los que
					// su nombre empiecen contengan la palabra 'Patron').
					// Explicaremos estos scripts más adelante.
					bool patronFound = false;
					MonoBehaviour[] milestoneScripts = HitosPatronMovimiento[HitoSiguiente].GetComponents<MonoBehaviour>();
					foreach (MonoBehaviour script in milestoneScripts)
					{
						if (script.GetType().Name.Contains("Patron"))
						{
							patronFound = true;
							script.enabled = true;
						}
					}
					// Si no encontramos ningún script de comportamiento en el hito, continuamos al siguiente
					if (!patronFound)
					{
						CanGoToNextMilestone = true;
					}

					// Calculamos cual será el próximom hito
					if (HitoSiguiente != HitosPatronMovimiento.Length - 1)
					{
						HitoSiguiente++;
					}
					else
					{
						HitoSiguiente = 0;
					}
				}
			}
			catch
			{
				HitoSiguiente++;
			}
		}

	}


private bool IrHaciaHito(Vector3 PosicionHito, float Velocidad) {
	// Calculamos la distancia entre el hito y el objeto
	Vector3 VectorHaciaObjetivo = PosicionHito - thisTransform.position;

	VectorHaciaObjetivo = new Vector3(VectorHaciaObjetivo.x, VectorHaciaObjetivo.y, VectorHaciaObjetivo.z);

	if (Math.Abs(VectorHaciaObjetivo.x) > 0.2F ||
		Math.Abs(VectorHaciaObjetivo.y) > 0.2F || 
		Math.Abs(VectorHaciaObjetivo.z) > 0.2F)
	{
		// Calculamos el vector de movimiento hacia el hito
		VectorHaciaObjetivo.Normalize();
		VectorHaciaObjetivo *= Velocidad;
		VectorHaciaObjetivo = new Vector3(VectorHaciaObjetivo.x, 
			VectorHaciaObjetivo.y, 
			VectorHaciaObjetivo.z);

		// Movemos el objeto hacia el hito
			if (VectorHaciaObjetivo.x > 0) {
				transform.localEulerAngles = new Vector3 (0, 180, (-180*(Mathf.Atan(VectorHaciaObjetivo.y/VectorHaciaObjetivo.x)))/3.14f);
			} else {
				transform.localEulerAngles = new Vector3 (0, 0, (180*(Mathf.Atan(VectorHaciaObjetivo.y/VectorHaciaObjetivo.x)))/3.14f);
			}
		thisTransform.Translate(VectorHaciaObjetivo * Time.deltaTime, Space.World);

		// El objeto aún no ha llegado al hito
		return false;
	}
	else
	{
		// El objeto ha llegado al hito
		return true;
	}
}
}