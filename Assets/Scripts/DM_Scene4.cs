using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DM_Scene4 : MonoBehaviour
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
        if (drunkCount == 3)
        {
            drunkMeter.SetActive(true);
            drunkMeter.GetComponent<Image>().fillAmount = 0.7f;
        }
        if (drunkCount <  3)
        {
            drunkMeter.SetActive(true);
            drunkMeter.GetComponent<Image>().fillAmount = 0.5f;
        } 
    }
}
