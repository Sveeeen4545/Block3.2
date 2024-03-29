using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    private float xRotation = 0f;

    public float deadzone = .1f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX;
        float inputY;

        if(Gamepad.all.Count > 0)
        {
            mouseSensitivity = 100f;
            
            inputX = Input.GetAxis("HorizontalLook") * mouseSensitivity * Time.deltaTime;
            inputY = Input.GetAxis("VerticalLook") * mouseSensitivity * Time.deltaTime;

            //Debug.Log("X: " + inputX + "Y: " + inputY);
        }
        else
        {
            mouseSensitivity = 100f;

            inputX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            inputY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        }

        //xRotation -= mouseY;
        xRotation -= inputY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //playerBody.Rotate(Vector3.up * mouseX);
        playerBody.Rotate(Vector3.up * inputX);

    }
}
