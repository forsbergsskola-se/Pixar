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
}
