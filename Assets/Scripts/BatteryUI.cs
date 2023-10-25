using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatteryUI : MonoBehaviour
{
    public UnityEvent light;
    public float batteryLevel;
    public Battery charge;

    public void Update()
    {
        batteryLevel = charge.GetCharge();
        
    }
}
