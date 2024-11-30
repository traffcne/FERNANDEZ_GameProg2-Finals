using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.Build.Content;

public class DrunkenessMeter : MonoBehaviour
{
    public static DrunkenessMeter Instance;

    public int drunkCount;
    public GameObject drunkMeter;

    private void Awake()
    {
        if (Instance !=null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void Update()
    {
        drunkTracker();
    }
    public void drunkTracker()
    {
        if (drunkCount == 0)
        {
            drunkMeter.SetActive(false);
        }

        if (drunkCount == 1) 
        { 
            drunkMeter.SetActive(true);
            drunkMeter.GetComponent<Image>().fillAmount = 0.2f;
        }
    }

    public int DrunkCount()
    {
        return drunkCount;
    }

    public GameObject DrunkMeter()
    {
        return drunkMeter;
    }
}
