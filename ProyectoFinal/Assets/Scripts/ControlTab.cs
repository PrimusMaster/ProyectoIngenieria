using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTab : MonoBehaviour
{
    public bool active;
    public GameObject Obj;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        Obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            if (active) 
            {
                Obj.SetActive(false);
                active = false;
            }
            else
            {
                Obj.SetActive(true);
                active = true;
            }

        }

        
    }
}
