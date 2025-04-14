using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDisparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float fuerzaDisparo = 20f;
    private Vector3 escalaBala = new Vector3(0.1f, 0.1f, 0.1f);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GameObject bala = Instantiate(balaPrefab, puntoDisparo.position, puntoDisparo.rotation);
         
            bala.transform.localScale = escalaBala;
            Rigidbody rb = bala.GetComponent<Rigidbody>();
            rb.velocity = puntoDisparo.forward * fuerzaDisparo;
            Destroy(bala, 1f);
        }
    }
}
