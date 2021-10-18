using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGame");

    }

   
    public void ExitGame() 
    {
        Application.Quit();
    }

    public void CreditsScreen() {
        SceneManager.LoadScene("CreditsScreen");
    }

    public void GoBack() {
        SceneManager.LoadScene("Menu");

    }
  


}
