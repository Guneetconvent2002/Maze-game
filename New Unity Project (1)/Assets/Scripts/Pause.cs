using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void pause()
    {
       
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
