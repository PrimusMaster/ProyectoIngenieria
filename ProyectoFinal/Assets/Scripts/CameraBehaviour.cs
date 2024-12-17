using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraBehaviour: MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float Horizontal  = -Input.GetAxis("Mouse Y");
        float Vertical = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(Horizontal, Vertical, 0));
    }
}
