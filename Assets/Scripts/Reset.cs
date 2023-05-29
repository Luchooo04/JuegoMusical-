using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Start()
    {
        // Guarda la posición inicial del jugador al iniciar el juego
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
        // Comprueba si la colisión es con un objeto que desencadena el reinicio de posición
        if (collision.gameObject.CompareTag("Reset"))
        {
            // Reinicia la posición del jugador a la posición inicial guardada
            transform.position = initialPosition;
        }
    }
}
