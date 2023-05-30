using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Start()
    {
       
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
       
        if (collision.gameObject.CompareTag("Reset"))
        {
            
            transform.position = initialPosition;
        }
    }
}
