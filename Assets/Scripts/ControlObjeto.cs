using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class ControlObjeto : MonoBehaviour
{
    public Transform player; // Referencia al transform del personaje
    public float moveSpeed = 5f; // Velocidad de movimiento del objeto
    public float detectionRange = 10f; // Rango de detecci�n del personaje

    private bool isPlayerInRange = false; // Indica si el personaje est� dentro del rango

    private void Update()
    {
        // Verifica si el personaje est� dentro del rango de detecci�n
        if (isPlayerInRange)
        {
            // Calcula la direcci�n hacia el jugador
            Vector3 directionToPlayer = player.position - transform.position;

            // Normaliza la direcci�n para obtener una velocidad constante
            Vector3 movement = directionToPlayer.normalized * moveSpeed * Time.deltaTime;

            // Mueve el objeto hacia el jugador
            transform.Translate(movement);

            // Verifica si el objeto ha colisionado con el personaje
            if (Vector3.Distance(transform.position, player.position) < 1f)
            {
                // Destruye el objeto
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el personaje ha entrado en el rango de detecci�n
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verifica si el personaje ha salido del rango de detecci�n
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
