using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviimiento : MonoBehaviour
{
    public float velocidad = 5f; 
    public float rotacion = 50f;

    void Update()
    {
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

       
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -rotacion * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, rotacion * Time.deltaTime);
    }
}
