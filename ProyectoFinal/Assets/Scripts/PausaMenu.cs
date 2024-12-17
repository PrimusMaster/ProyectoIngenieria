using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PausaMenu : MonoBehaviour
{

    public GameObject pauseMenu;

    public GameObject pauseFirstButton, optionCloseButton;

    public void P1()
    {
        SceneManager.LoadScene(2);
    }

    public void Unpause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if (!pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;  
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }

}
