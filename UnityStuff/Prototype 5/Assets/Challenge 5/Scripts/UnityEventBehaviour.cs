using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventBehaviour : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
    }
}
