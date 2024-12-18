using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AreaDetection : MonoBehaviour
{

    public UnityEvent evento;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Playerbehaviour>().intermitente) 
        {
            evento.Invoke();
        }
    }
}
