using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastDogTime;
    private float spawningLimit = 1f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && lastDogTime >= spawningLimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastDogTime = 0;
        }
        lastDogTime += Time.deltaTime;
    }
}
