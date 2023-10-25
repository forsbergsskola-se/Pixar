﻿using UnityEngine;

public class Light : MonoBehaviour
{
    public Battery battery;
    public SpriteRenderer lightBeam;
    public void OnLampChange(Lamp lamp)
    {
        bool isTurnedOn = lamp.GetIsTurnedOn();
        this.lightBeam.enabled = isTurnedOn;

    }

    public void LosingLight(Battery battery)
    {
        float charge = this.battery.GetCharge();
        this.lightBeam.transform.localScale = new Vector3(4, 4, 1)*charge;
        // now go to 0
    }
}
