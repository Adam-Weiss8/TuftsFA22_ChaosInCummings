using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    [SerializeField] GameObject endMenu; 

    void Start()
    {
        endMenu.SetActive(false);
    }
    
    public void endGame()
    {
        Time.timeScale = 0f;
        endMenu.SetActive(true);
    }
    

    public void QuitGame3()
    {
        Application.Quit();
    }

    public void MainMenu2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
