using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class TextScene4 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject pauseMenu;
    public GameObject Buttons;
    public GameObject pauseButtons;

    public TMP_Text[] sc4Dialogue;

    public GameObject[] Portraits;

    private void Awake()
    {
        sc4Dialogue[0].gameObject.SetActive(true);
        TextBox.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Close1()
    {
        sc4Dialogue[0].gameObject.SetActive(false);
        TextBox.SetActive(false);
        Buttons.SetActive(true);
    }

    public void Jack()
    {
        Portraits[0].gameObject.SetActive(true);
        Portraits[2].gameObject.SetActive(true);
        TextBox.SetActive(true);
        sc4Dialogue[1].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Rebutt()
    {
        Portraits[2].gameObject.SetActive(false);
        Portraits[1].gameObject.SetActive(true);
        sc4Dialogue[1].gameObject.SetActive(false);
        sc4Dialogue[2].gameObject.SetActive(true);
    }

    public void convoEnd()
    {
        Portraits[1].gameObject.SetActive(false);
        Portraits[0].gameObject.SetActive(false);
        sc4Dialogue[2].gameObject.SetActive(false);
        TextBox.SetActive(false);
        Buttons.SetActive(true);
    }

    public void emptyBottle()
    {
        TextBox.SetActive(true);
        sc4Dialogue[3].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }
    
    public void closeEmpty()
    {
        TextBox.SetActive(false);
        sc4Dialogue[3].gameObject.SetActive(false);
        Buttons.SetActive(true);
    }

    public void fullBottle()
    {
        TextBox.SetActive(true);
        sc4Dialogue[4].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Drink()
    {
        DrunkenessMeter.Instance.drunkCount++;
        sc4Dialogue[4].gameObject.SetActive(false);
        sc4Dialogue[5].gameObject.SetActive(true);
    }

    public void Abstain()
    {
        sc4Dialogue[4].gameObject.SetActive(false);
        sc4Dialogue[6].gameObject.SetActive(true);
    }

   public void Bathroom()
    {
        sc4Dialogue[5].gameObject.SetActive(false);
        sc4Dialogue[6].gameObject.SetActive(false);
        sc4Dialogue[7].gameObject.SetActive(true);
    }

    public void moveToEnd2()
    {
        SceneManager.LoadScene(6);
    }





    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        pauseButtons.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButtons.SetActive(false);
        Buttons.SetActive(true);
    }

    public void gameReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameQuit()
    {
        SceneManager.LoadScene(0);
    }
}
