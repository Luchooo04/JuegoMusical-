using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PisarPlataforma : MonoBehaviour
{
    public GameObject manoDerecha;
    public GameObject manoIzquierda;

    void Start()
    {

    }

    void Update()
    {

    }

    public void ActivarManos()
    {
        manoDerecha.SetActive(true);
        manoIzquierda.SetActive(true);
    }
    public void DesactivarManos()
    {
        manoDerecha.SetActive(false);
        manoIzquierda.SetActive(false);
    }
}
