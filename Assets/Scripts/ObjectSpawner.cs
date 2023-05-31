using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnInterval = 1f;
    public float objectSpeed = 5f;

    private GameObject spawnedObject;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            DestroyPreviousObject();
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        spawnedObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * objectSpeed;
    }

    private void DestroyPreviousObject()
    {
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
