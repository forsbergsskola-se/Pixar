using UnityEngine;
using UnityEngine.UI;

public class Darkness : MonoBehaviour
{
    public Image fullScreenImage;
    private Color desiredColor;
    
    // Start is called before the first frame update
    void Start()
    {
        desiredColor = fullScreenImage.color;
    }

    public void OnLampChange(Lamp lamp)
    {
        bool isTurnedOn = lamp.GetIsTurnedOn();
        UpdateDarkness(isTurnedOn);
    }

    [ContextMenu("Test Turn On")]
    public void TestTurnOn()
    {
        UpdateDarkness(true);
    }
    
    [ContextMenu("Test Turn Off")]
    public void TestTurnOff()
    {
        UpdateDarkness(false);
    }

    private void UpdateDarkness(bool isTurnedOn)
    {
        if (isTurnedOn)
        {
            this.desiredColor.a = 40 / 255f;
        }
        else
        {
            this.desiredColor.a = 240 / 255f;
        }

        this.fullScreenImage.color = this.desiredColor;
    }
}
