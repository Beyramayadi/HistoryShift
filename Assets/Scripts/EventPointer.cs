using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPointer : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;
    [SerializeField] float amplitude = 2.0f;
    [SerializeField] float frequency = 0.50f;
    //LocationStatus playerLocation;
      //  public Vector2d eventPose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FloatAndRotatePointer();
    }
    void FloatAndRotatePointer()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); ;
    //    transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude) * 15, transform.position.z);
    }

}
