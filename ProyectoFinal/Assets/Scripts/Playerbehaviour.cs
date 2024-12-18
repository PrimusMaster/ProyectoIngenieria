using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerbehaviour : MonoBehaviour
{

    
    public float Velocidad = 0f;
    public float Giro = 20f;
    public float Velocidad_Maxima = 50f;
    public float Velocidad_Maxima_Reversa = -30f;
    public float Aceleracion_Ritmo = .01f;
    public float Desaceleracion_Ritmo = .08f;
    public Rigidbody Ritmo;

    public bool intermitente;


    // Start is called before the first frame update
    void Start()
    {
        Velocidad = 0;
        Ritmo = GetComponent<Rigidbody>();
        intermitente = false;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Comportamiento();
    }

    void Accelerate()
    {
        if (Velocidad < Velocidad_Maxima)
        {
            Velocidad += Aceleracion_Ritmo;

        }
        else
        {
            Velocidad = Velocidad_Maxima;
        }
    }

    void Decelerate()
    {
        if (Velocidad > Velocidad_Maxima_Reversa)
        {
            Velocidad -= Aceleracion_Ritmo;
        }
        else
        {
            Velocidad = Velocidad_Maxima_Reversa;

        }

    }

    private void Stop()
    {
        if (Velocidad > 0) 
        {
            Velocidad -= Desaceleracion_Ritmo;

        }
        else if (Velocidad < 0)
        {
            Velocidad += Desaceleracion_Ritmo;

        }
        else 
        {
            Velocidad = 0;
        }

    }

    void Toggle()
    {
        intermitente = !intermitente;
    }

    void Comportamiento()
    {
        transform.Translate(new Vector3(0,0,Velocidad)*Time.deltaTime*-1);

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 1, 0), Giro * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, 1, 0), Giro * Time.deltaTime * -1);
            }
            Accelerate();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 1, 0), -Giro * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, 1, 0), -Giro * Time.deltaTime * -1);
            }
            Decelerate();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Stop();
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            Toggle();
        }
        else
        {
            Stop();
        }

        
    }
}
