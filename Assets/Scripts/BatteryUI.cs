using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatteryUI : MonoBehaviour
{
    public UnityEvent light;
    public Battery charge;
    public float batteryLevel = charge.GetCharge();

    public void Update()
    {
        
    }
}
