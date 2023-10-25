using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Battery : MonoBehaviour
{
    public UnityEvent<Battery> BatteryChargeChangeEvent;

    public void AddCharge(float amount)
    {
        throw new NotImplementedException();
    }

    public float GetCharge()
    {
        throw new NotImplementedException();
    }

    public void ConsumeCharge(float amount)
    {
        throw new NotImplementedException();
    }
    
}
