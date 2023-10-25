using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Battery : MonoBehaviour

{
    public UnityEvent<Battery> BatteryChargeChangeEvent;

    private float maxCharge = 100f;
    private float minCharge = 0f;
    private float currentCharge = 0.0f;
    
    
    public void AddCharge(float amount)
    {
        currentCharge += amount; //incrementing the values and changes the value on the currentCharge
        if (currentCharge > maxCharge)
        {
            currentCharge = maxCharge;
        }
    }

    public float GetCharge()
    {
        return this.currentCharge;
    }

    public void ConsumeCharge(float amount)
    {
        currentCharge -= amount; // subtracts the amount from the currentCharge
        if (currentCharge < minCharge)
        {
            currentCharge = minCharge; //Checks so that you cant remove more from the battery than the minCharge
        }
        
    }
    
}
