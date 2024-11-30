using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{ 
   public void loadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
