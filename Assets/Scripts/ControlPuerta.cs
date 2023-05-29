using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuerta : MonoBehaviour
{
    public float openAngle = 90f;  // Ángulo de apertura de la puerta
    public float openSpeed = 2f;  // Velocidad de apertura de la puerta

    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private bool isOpen = false;

    private void Start()
    {
        initialRotation = transform.rotation;
        targetRotation = Quaternion.Euler(0f, openAngle, 0f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Cambiar el estado de apertura de la puerta
            isOpen = !isOpen;
        }

        // Interpolar la rotación de la puerta hacia la rotación objetivo
        Quaternion newRotation = isOpen ? targetRotation : initialRotation;
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, openSpeed * Time.deltaTime);
    }
}
