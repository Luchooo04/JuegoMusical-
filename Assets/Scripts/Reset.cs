using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Start()
    {
        // Guarda la posici�n inicial del jugador al iniciar el juego
        initialPosition = transform.position;
    }
    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
           transform.position = initialPosition;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Comprueba si la colisi�n es con un objeto que desencadena el reinicio de posici�n
        if (collision.gameObject.CompareTag("Reset"))
        {
            // Reinicia la posici�n del jugador a la posici�n inicial guardada
            transform.position = initialPosition;
        }
    }
}
