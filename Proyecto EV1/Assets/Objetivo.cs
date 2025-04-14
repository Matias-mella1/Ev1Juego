using UnityEngine;

public class Objetivo : MonoBehaviour
{
    private int vidaObjetivo;

    void Start()
    {
        vidaObjetivo = ControladorDificultad.disparosNecesarios;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidaObjetivo--;

            if (vidaObjetivo <= 0)
            {
                Destroy(gameObject);

                Puntaje puntaje = FindAnyObjectByType<Puntaje>();
                if (puntaje != null)
                {
                    puntaje.ObjetivoDestruido(); 
                }
            }
        }
    }
}
