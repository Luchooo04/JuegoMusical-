using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarNota : MonoBehaviour
{
    public GameObject pulsarTecla;
    public GameObject notaVisual;
    public bool Activa;


   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)&&Activa==true) 
        {
            notaVisual.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && Activa == true) 
        {
            notaVisual.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player") 
        {
            Activa = true;
            pulsarTecla.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            Activa = false;
            pulsarTecla.SetActive(false);
            notaVisual.SetActive(false);
        }
    }
}
