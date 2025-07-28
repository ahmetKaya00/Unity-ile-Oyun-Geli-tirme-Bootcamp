using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    void Start()
    {
        ActiveCamera(Camera1);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            ActiveCamera(Camera1);
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiveCamera(Camera2);
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiveCamera(Camera3);
        }
    }
    void ActiveCamera(Camera activeCamera)
    {
        Camera1.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(false);
        Camera3.gameObject.SetActive(false);

        activeCamera.gameObject.SetActive(true);
    }
}
