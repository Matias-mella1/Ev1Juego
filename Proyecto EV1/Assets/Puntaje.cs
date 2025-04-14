using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public int puntuacion = 0;
    private float tiempo = 0f;

    void Start()
    {
        int ultimaPuntuacion = PlayerPrefs.GetInt("UltimaPuntuacion", 0);
        Debug.Log("Última puntuación: " + ultimaPuntuacion);
    }

    void Update()
    {
      
        tiempo += Time.deltaTime;
        if (tiempo >= 3f)
        {
            Debug.Log("Puntuación actual: " + puntuacion);
            tiempo = 0f;
        }
    }

   
    public void ObjetivoDestruido()
    {
        puntuacion++;
    }

    void OnApplicationQuit()
    {
       
        PlayerPrefs.SetInt("UltimaPuntuacion", puntuacion);
        PlayerPrefs.Save();
    }
}
