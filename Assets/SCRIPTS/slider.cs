using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider yourSlider; // Reference to your Slider component in the Unity Editor

    void Start()
    {
        // Disable user interaction with the slider
        yourSlider.interactable = false;
    }
}
