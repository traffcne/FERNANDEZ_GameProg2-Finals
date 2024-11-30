using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScene3 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject pauseMenu;
    public GameObject Buttons;
    public GameObject pauseButtons;

    public TMP_Text[] sc3Dialogue;

    public GameObject[] Portraits;

    private void Awake()
    {
        sc3Dialogue[0].gameObject.SetActive(true);
        TextBox.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Close1()
    {
        sc3Dialogue[0].gameObject.SetActive(false);
        TextBox.SetActive(false);
        Buttons.SetActive(true);
    }

    public void interactMCTOffice()
    {
        Portraits[0].gameObject.SetActive(true);
        Portraits[2].gameObject.SetActive(true);
        TextBox.SetActive(true);
        sc3Dialogue[1].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void closeMCTOffice()
    {
        Portraits[0].gameObject.SetActive(false);
        Portraits[2].gameObject.SetActive(false);
        TextBox.SetActive(false);
        sc3Dialogue[1].gameObject.SetActive(false);
        Buttons.SetActive(true);
    }

    public void interactInsignia()
    {
        TextBox.SetActive(true);
        sc3Dialogue[2].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }
    public void closeInsignia()
    {
        TextBox.SetActive(false);
        sc3Dialogue[2].gameObject.SetActive(false);
        Buttons.SetActive(true);
    }

    public void Irving1()
    {
        Portraits[0].gameObject.SetActive(true);
        Portraits[3].gameObject.SetActive(true);
        TextBox.SetActive(true);
        sc3Dialogue[3].gameObject.SetActive(true);
        Buttons.SetActive(false);
    }

    public void Rebutt1()
    {
        Portraits[3].gameObject.SetActive(false);
        Portraits[2].gameObject.SetActive(true);
        sc3Dialogue[3].gameObject.SetActive(false);
        sc3Dialogue[4].gameObject.SetActive(true);
    }
    
    public void Irving2()
    {
        Portraits[2].gameObject.SetActive(false);
        Portraits[3].gameObject.SetActive(true);
        sc3Dialogue[4].gameObject.SetActive(false);
        sc3Dialogue[5].gameObject.SetActive(true);
    }
    public void Rebutt2()
    {
        Portraits[3].gameObject.SetActive(false);
        Portraits[1].gameObject.SetActive(true);
        sc3Dialogue[5].gameObject.SetActive(false);
        sc3Dialogue[6].gameObject.SetActive(true);
    }
    public void Irving3()
    {
        Portraits[1].gameObject.SetActive(false);
        Portraits[3].gameObject.SetActive(true);
        sc3Dialogue[6].gameObject.SetActive(false);
        sc3Dialogue[7].gameObject.SetActive(true);
    }

    public void ch1End1()
    {
        SceneManager.LoadScene(5);
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
