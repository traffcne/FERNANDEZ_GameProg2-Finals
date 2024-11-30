using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextScene2 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject pauseMenu;
    public GameObject Buttons;
    public GameObject pauseButtons;

    public TMP_Text[] sc2Dialogue;

    public DM_Scene2 DM2;

    private void Awake()
    {
        sc2Dialogue[0].gameObject.SetActive(true);
        TextBox.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Close1()
    {
        sc2Dialogue[0].gameObject.SetActive(false);
        TextBox.SetActive(false);
        Buttons.SetActive(true);
    }

    public void interactCoat()
    {
        TextBox.SetActive(true);
        sc2Dialogue[1].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void closeCoat()
    {
        TextBox.SetActive(false);
        sc2Dialogue[1].gameObject.SetActive(false);
        Buttons.SetActive(true);
    }


    public void interactDoor()
    {
        TextBox.SetActive(true);
        Buttons.SetActive(false);
        if (DM2.drunkCount == 0)
        {
            sc2Dialogue[2].gameObject.SetActive(true);
        }
        else if (DM2.drunkCount >=1)
        {
            sc2Dialogue[3].gameObject.SetActive(true);
        }
    }

    public void leaveHouse()
    {
        Buttons.SetActive(false);
        if (DM2.drunkCount == 0)
        {
            sc2Dialogue[2].gameObject.SetActive(false);
            SceneManager.LoadScene(3);
        }
        else if (DM2.drunkCount >= 1)
        {
            sc2Dialogue[3].gameObject.SetActive(false);
            sc2Dialogue[4].gameObject.SetActive(true);
        }
    }

    public void Drink()
    {
        DrunkenessMeter.Instance.drunkCount++;
        sc2Dialogue[4].gameObject.SetActive(false);
        sc2Dialogue[5].gameObject.SetActive(true);
    }

    public void Abstain()
    {
        sc2Dialogue[4].gameObject.SetActive(false);
        sc2Dialogue[6].gameObject.SetActive(true);
    }

    public void Bar()
    {
        if (DM2.drunkCount >= 1)
        {
            SceneManager.LoadScene(4);
        }
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
