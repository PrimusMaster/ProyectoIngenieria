// Created by NightTime Developments!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mainmenu : MonoBehaviour
{

    public void GameStart()
    {
        SceneManager.LoadScene(2);
    }

    public void Scores()
    {
        SceneManager.LoadScene(2);
    }

    public void Config()
    {
        SceneManager.LoadScene(2);
    }

    public void LogIn()
    {
        SceneManager.LoadScene(2);
    }


public void Quit()
    {
        Application.Quit();
    }


// Start is called before the first frame update

public void Start(){

    }


    // Update is called once per frame
    void Update(){
     
     }
}


