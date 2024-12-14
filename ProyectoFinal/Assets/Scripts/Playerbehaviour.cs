using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbehaviour : MonoBehaviour
{
    public int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal,0.0f,vertical)*Time.deltaTime*speed);
        float Xaxis = Input.GetAxis("Mouse X");
        float Yaxis = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(Yaxis,Xaxis,0.0f));   
        
    }
}
