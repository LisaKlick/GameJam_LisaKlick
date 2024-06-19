using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    float TotalClicks;

    bool hasUpgrade;

    public int autoClickPerSecond;
    public int minimumClicksToUnlock;

    public void AddClicks()
    {
        TotalClicks++;

        ClicksTotalText.text = TotalClicks.ToString("0");

    }

    public void AutoClickUpgrade()
    {
        if(!hasUpgrade && TotalClicks >= minimumClicksToUnlock)
        {
            TotalClicks -= minimumClicksToUnlock;
            hasUpgrade = true;
        }

        
    }

    private void Update()
    {
        if(hasUpgrade)
        {
            TotalClicks += autoClickPerSecond * Time.deltaTime;

            ClicksTotalText.text = TotalClicks.ToString("0");
        }
    }

}
