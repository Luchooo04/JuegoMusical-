using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionPlat : MonoBehaviour
{
    public PisarPlataforma pisarPlataforma;

    private void Start()
    {
        pisarPlataforma = GameObject.FindGameObjectWithTag("Player").GetComponent<PisarPlataforma>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pisarPlataforma.ActivarManos();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pisarPlataforma.DesactivarManos();
        }
    }
}
