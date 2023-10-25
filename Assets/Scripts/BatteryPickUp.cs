using Unity.VisualScripting;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GameObject().GetComponent<Battery>();
        Battery battery = other.GameObject().GetComponent<Battery>();
        battery.AddCharge(0.3f);
    }
}
