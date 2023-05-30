using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarRadio : MonoBehaviour
{
    public GameObject EncenderRadio;
    private bool enter;

    public AudioSource musica;
    void Update()
    {
        if (Input.GetKeyDown("f")) 
        { 
         musica.Play();
        }
    }
    //private void OnGUI()
    //{
    //    if (enter)
    //    {

    //        GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Presiona 'F' para prender");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EncenderRadio.SetActive(true);
            enter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            EncenderRadio.SetActive(false);
            enter = false;
        }
    }
}
