using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class BatteryUI : MonoBehaviour
{
    public float batteryLevel;
    public Battery charge;

    public Image BatteryColor;
    void Start()
    {
        
    }

    public void Update()
    {
        batteryLevel = charge.GetCharge();

        BatteryColor.fillAmount = batteryLevel / 100f;

        if (batteryLevel < 20f)
            BatteryColor.color = Color.red;
        else if (batteryLevel < 50f)
            BatteryColor.color = Color.yellow;
        else
            BatteryColor.color = Color.green;
    }
}
