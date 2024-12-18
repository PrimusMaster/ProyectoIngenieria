using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Camera2;
    public bool estado;

    // Start is called before the first frame update
    void Start()
    {
        estado = false;
        Camera.SetActive(true);
        Camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            if(estado == false)
            {
                Camera.SetActive (false);
                Camera2.SetActive (true);
                estado = true;
            }
            else 
            {
                Camera.SetActive(true);
                Camera2.SetActive(false);
                estado = false;
            }
           
        }
    }




}
