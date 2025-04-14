using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo : MonoBehaviour
{

    public float velocidad = 2f;
    private Rigidbody rb;
    private Vector3 direccion;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direccion = transform.forward;  
        
    }

    void FixedUpdate()
    {
        Vector3 posicionNueva = rb.position + direccion * velocidad * Time.fixedDeltaTime;
        rb.MovePosition(posicionNueva);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            direccion = -direccion;  
        }
    }

}
