using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPhaseLogger : MonoBehaviour
{
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Dokunma Ba�lad�!");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Dokunma hareket etti!");
                    break;
                case TouchPhase.Stationary:
                    Debug.Log("Dokunma Sabit!");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Dokunma Bitti!");
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Dokunma �ptal Edildi!");
                    break;
            }

            float screenWidth = Screen.width;
            float screenHeight = Screen.height;

            if(touch.position.x < screenWidth / 2)
            {
                Debug.Log("Sola Dokundu");
            }
            else
            {
                Debug.Log("Sa�a Dokundu");
            }
            if (touch.position.y < screenHeight / 2)
            {
                Debug.Log("A�a�� Dokundu");
            }
            else
            {
                Debug.Log("Yukar� Dokundu");
            }
        }
    }
}
