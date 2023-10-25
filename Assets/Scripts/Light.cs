using UnityEngine;

public class Light : MonoBehaviour
{
    public SpriteRenderer lightBeam;
    public void OnLampChange(Lamp lamp)
    {
        bool isTurnedOn = lamp.GetIsTurnedOn();
        this.lightBeam.enabled = isTurnedOn;

    }
}
