using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextScene6 : MonoBehaviour
{
    public TMP_Text sc6Dialogue;

    public GameObject TextBox;
    public GameObject Button;
    private void Awake()
    {
        sc6Dialogue.gameObject.SetActive(true);
        TextBox.SetActive(true);
        Button.SetActive(false);
    }

    public void Close1()
    {
        sc6Dialogue.gameObject.SetActive(false);
        TextBox.SetActive(false);
        Button.SetActive(true);
    }

    public void endChapter()
    {
        SceneManager.LoadScene(7);
    }
}
