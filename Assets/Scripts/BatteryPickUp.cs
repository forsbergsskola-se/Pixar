using Unity.VisualScripting;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GameObject().GetComponent<Battery>();
        Battery battery = other.GameObject().GetComponent<Battery>();
        battery.AddCharge(30f);
    }
}
