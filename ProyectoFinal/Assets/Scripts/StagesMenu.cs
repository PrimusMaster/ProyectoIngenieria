// Created by NightTime Developments!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stagesmenu : MonoBehaviour
{

    public void P1()
    {
        SceneManager.LoadScene(1);
    }

    public void P2()
    {
        SceneManager.LoadScene(4);
    }

    public void P3()
    {
        SceneManager.LoadScene(3);
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }


    // Start is called before the first frame update

    public void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}
