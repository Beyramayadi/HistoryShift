using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float minScale = 0.8f;   // Minimum scale of the background
    public float maxScale = 1.2f;   // Maximum scale of the background
    public float zoomSpeed = 0.5f; // Speed of the zoom effect

    private Vector3 initialScale;
    private bool zoomingIn = true;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Calculate the new scale factor
        float newScale = Mathf.PingPong(Time.time * zoomSpeed, maxScale - minScale) + minScale;

        // Smoothly interpolate the scale to create a gradual zoom effect
        float smoothScale = Mathf.Lerp(transform.localScale.x, newScale, Time.deltaTime);

        // Apply the new scale to the background
        transform.localScale = new Vector3(smoothScale, smoothScale, 1);

        // Change the zooming direction when reaching the max or min scale
        if (Mathf.Approximately(smoothScale, minScale) || Mathf.Approximately(smoothScale, maxScale))
        {
            zoomingIn = !zoomingIn;
        }
    }
}
