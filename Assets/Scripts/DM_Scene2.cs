using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DM_Scene2 : MonoBehaviour
{
    public int drunkCount;

    public GameObject drunkMeter;
    private void Awake()
    {
        drunkCount = DrunkenessMeter.Instance.drunkCount;
    }

    public void Update()
    {
        drunkTracker();
    }
    public void drunkTracker()
    {
        drunkCount = DrunkenessMeter.Instance.drunkCount;
        if (drunkCount == 0)
        {
            drunkMeter.SetActive(false);
        }

        if (drunkCount == 1)
        {
            drunkMeter.SetActive(true);
            drunkMeter.GetComponent<Image>().fillAmount = 0.2f;
        }

        if (drunkCount == 2) 
        {
            drunkMeter.SetActive(true);
            drunkMeter.GetComponent<Image>().fillAmount = 0.5f;
        }
    }
}
