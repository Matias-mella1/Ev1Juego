using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform tanque;
    public Vector3 offset;
    public float velocidad = 10f;


    void LateUpdate()
    {
        Vector3 posicionDeseada = tanque.position + offset;
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, velocidad * Time.deltaTime);
        transform.LookAt(tanque);
    }
}
