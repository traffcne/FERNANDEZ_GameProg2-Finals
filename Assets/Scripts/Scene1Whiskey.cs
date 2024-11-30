using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Scene1Whiskey : MonoBehaviour
{
    public UnityEngine.UI.Button Whiskey;

    public TMP_Text[] choice1Text;

    public TextScene1 Scene1;
    public DrunkenessMeter drunkM;

    private bool hasAbstained;
    public bool isPaused;

    public void Update()
    {
        pauseCheck();
        textCheck();
    }
    public void pauseCheck()
    {
        if (isPaused == true)
        {
            Whiskey.gameObject.SetActive(false);
        }
    }
    public void textCheck()
    {
        if (Scene1.sc1Dialogue[0].gameObject.activeSelf == false && Scene1.sc1Dialogue[1].gameObject.activeSelf == false && Scene1.sc1Dialogue[2].gameObject.activeSelf == false)
        {
            if (isPaused == false && drunkM.drunkCount == 0 && hasAbstained == false)
            {
                Whiskey.gameObject.SetActive(true);
            }
            else if (drunkM.drunkCount >= 1 || hasAbstained == true)
            {
                Whiskey.gameObject.SetActive(false);
            }
        }
    }

    public void interactWhiskey()
    {
        Scene1.TextBox.SetActive(true);
        choice1Text[0].gameObject.SetActive(true);
        Scene1.Buttons.gameObject.SetActive(false);
    }

    public void Drink1()
    {
        drunkM.drunkCount++;
        choice1Text[0].gameObject.SetActive(false);
        choice1Text[1].gameObject.SetActive(true);
    }

    public void closeDrink1()
    {
        choice1Text[1].gameObject.SetActive(false);
        Scene1.TextBox.gameObject.SetActive(false);
        Scene1.Buttons.gameObject.SetActive(true);
    }

    public void Abstain1()
    {
        choice1Text[0].gameObject.SetActive(false);
        choice1Text[2].gameObject.SetActive(true);
        hasAbstained = true;
    }

    public void closeAbstain1()
    {
        choice1Text[2].gameObject.SetActive(false);
        Scene1.TextBox.gameObject.SetActive(false);
        Scene1.Buttons.gameObject.SetActive(true);
    }

    




}
