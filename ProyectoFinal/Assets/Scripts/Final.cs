using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Final : MonoBehaviour
{
    public UnityEvent evento;


    private void OnTriggerEnter(Collider other)
    {
        evento.Invoke();
    }
}
