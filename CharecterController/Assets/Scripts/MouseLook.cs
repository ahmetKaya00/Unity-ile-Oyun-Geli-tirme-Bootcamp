using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensivity = 100f;
    [SerializeField] Transform bodyTransform;
    [SerializeField] Joystick lookJoystick;

    float xRotation = 0f;

    void Update()
    {
        float mouseX = lookJoystick.Horizontal * mouseSensivity * Time.deltaTime;
        float mouseY = lookJoystick.Vertical * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        bodyTransform.Rotate(Vector3.up * mouseX);
    }
}
