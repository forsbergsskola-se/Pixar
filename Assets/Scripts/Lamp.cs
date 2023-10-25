using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lamp : MonoBehaviour
{
    public UnityEvent<Lamp> LampOnChangeEvent;
    private bool IsLampOn;
    public void TurnOn()
    {
        IsLampOn = true;
        LampOnChangeEvent.Invoke(this);
    }

    public bool GetIsTurnedOn()
    {
        return IsLampOn;
    }

    public void TurnOff()
    {
        IsLampOn = false;
        LampOnChangeEvent.Invoke(this);
    }

    public void FixedUpdate()
    {
        if (IsLampOn == true)
        {
            this.gameObject.GetComponent<Battery>().ConsumeCharge(0.0005f);
        }
    }

    void Start()
    {
        LampOnChangeEvent.Invoke(this);
    }
    
    void Update(){
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(this.IsLampOn)
                TurnOff();
            else
                TurnOn();
        }
    }
}