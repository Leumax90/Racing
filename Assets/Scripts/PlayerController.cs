using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Switch Camera our vehicle
    public Camera MainCamera;
    public Camera HoodCamera;
    public KeyCode switchCamera;

    // Move vehicle
    private float speed = 15.0f;
    private float turnspeed = 30.0f;
    private float horizontalInput;
    private float verticallInput;
    public float InputID;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Switch Camera our vehicle

        if (Input.GetKeyDown(switchCamera))
        {
            MainCamera.enabled = !MainCamera.enabled;
            HoodCamera.enabled = !HoodCamera.enabled;
        }

        horizontalInput = Input.GetAxis("Horizontal" + InputID);
        verticallInput = Input.GetAxis("Vertical" + InputID);
        // Move vehicle with controller

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticallInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);
    }
}
