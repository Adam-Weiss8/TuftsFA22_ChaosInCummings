using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{

    [SerializeField] GameObject dieMenu; 

    void Start()
    {
        dieMenu.SetActive(true);
    }
    
    public void playerDied()
    {
        Time.timeScale = 0f;
        dieMenu.SetActive(true);
    }
    
    public void QuitGame5()
    {
        Application.Quit();
    }

    public void MainMenu5()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
