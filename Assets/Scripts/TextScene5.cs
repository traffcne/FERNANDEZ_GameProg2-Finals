using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScene5 : MonoBehaviour
{
    public TMP_Text sc5Dialogue;

    public GameObject TextBox;
    public GameObject Button;
    private void Awake()
    {
        sc5Dialogue.gameObject.SetActive(true);
        TextBox.SetActive(true);
        Button.SetActive(false);
    }

    public void Close1()
    {
        sc5Dialogue.gameObject.SetActive(false);
        TextBox.SetActive(false);
        Button.SetActive(true);
    }

    public void endChapter()
    {
        SceneManager.LoadScene(7);
    }
}
