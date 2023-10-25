using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class BatteryUI : MonoBehaviour
{
    public float batteryLevel;

    public Battery charge;
    public Image BatteryColor;

    public Text batteryPercentage;

    public void Update()
    {
        batteryLevel = charge.GetCharge();

        if (batteryLevel < 20f) //Deciding color depending on battery level
            BatteryColor.color = Color.red;
        else if (batteryLevel < 50f)
            BatteryColor.color = Color.yellow;
        else
            BatteryColor.color = Color.green;

        batteryPercentage.text = $"{batteryLevel:P}";
    }
}