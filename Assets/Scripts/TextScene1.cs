using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScene1 : MonoBehaviour
{
    public DrunkenessMeter drunkM;
    public Scene1Whiskey sc1Whiskey;

    public GameObject TextBox;
    public GameObject pauseMenu;
    public GameObject Buttons;
    public GameObject pauseButtons;

    public TMP_Text[] sc1Dialogue;

    private void Awake()
    {
        sc1Dialogue[0].gameObject.SetActive(true);
        TextBox.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Continue1()
    {
        sc1Dialogue[0].gameObject.SetActive(false);
        sc1Dialogue[1].gameObject.SetActive(true);
    }

    public void Continue2() 
    {
        sc1Dialogue[1].gameObject.SetActive(false);
        sc1Dialogue[2].gameObject.SetActive(true);
    }
    public void Close1()
    {
        sc1Dialogue[2].gameObject.SetActive(false);
        TextBox.SetActive(false);
        Buttons.SetActive(true);
    }

    public void interactLantern()
    {
        TextBox.SetActive(true);
        sc1Dialogue[3].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void closeLantern()
    {
        TextBox.SetActive(false);
        sc1Dialogue[3].gameObject.SetActive(false);
        Buttons.SetActive(true);
    }

    public void interactWatch()
    {
        TextBox.SetActive(true);
        sc1Dialogue[4].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void closeWatch()
    {
        TextBox.SetActive(false);
        sc1Dialogue[4].gameObject.SetActive(false);
        Buttons.SetActive (true);
    }

    public void interactWindow()
    {
        TextBox.SetActive(true);
        sc1Dialogue[5].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void closeWindow()
    { 
        TextBox.SetActive(false);
        sc1Dialogue[5].gameObject.SetActive(false);
        Buttons.SetActive(true);
    }

    public void interactGun()
    {
        TextBox.SetActive(true);
        Buttons.SetActive(false);
        if (drunkM.drunkCount == 0)
        {
            sc1Dialogue[6].gameObject.SetActive(true);
        }
        else if (drunkM.drunkCount >= 1)
        {
            sc1Dialogue[7].gameObject.SetActive(true);
        }
    }

    public void closeGun()
    {
        TextBox.SetActive(false);
        Buttons.SetActive(true);
        if (drunkM.drunkCount == 0)
        {
            sc1Dialogue[6].gameObject.SetActive(false);
        }
        else if (drunkM.drunkCount >= 1)
        {
            sc1Dialogue[7].gameObject.SetActive(false);
        }
    }

    public void moveToDoor()
    {
        SceneManager.LoadScene(2);
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        pauseButtons.SetActive(true);
        Buttons.SetActive(false);
        sc1Whiskey.isPaused = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButtons.SetActive(false);
        Buttons.SetActive(true);
        sc1Whiskey.isPaused = false;
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
