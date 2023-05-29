using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioAudio : MonoBehaviour
{
    public AudioClip audioPasosX;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<AudioSource>().clip = audioPasosX;
        }
    }
   
}
