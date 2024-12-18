using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float Xaxis = Input.GetAxis("Mouse X");
        float Yaxis = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-Yaxis, Xaxis, 0.0f));
    }
}
