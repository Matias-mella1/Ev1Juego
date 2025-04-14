using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDificultad : MonoBehaviour
{
    public enum Dificultad
    {
        Facil = 1,
        Medio = 2,
        Dificil = 3
    }

    
    public Dificultad dificultad = Dificultad.Facil;

    public static int disparosNecesarios = 1;

    void Awake()
    {
        switch (dificultad)
        {
            case Dificultad.Facil:
                disparosNecesarios = 1;
                break;
            case Dificultad.Medio:
                disparosNecesarios = 2;
                break;
            case Dificultad.Dificil:
                disparosNecesarios = 3;
                break;
        }

        Debug.Log("Dificultad : " + dificultad + " - Disparos necesarios: " + disparosNecesarios);
    }
}
