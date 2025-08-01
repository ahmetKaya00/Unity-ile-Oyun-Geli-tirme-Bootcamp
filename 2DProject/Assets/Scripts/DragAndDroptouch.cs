using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDroptouch : MonoBehaviour
{
    public float _speed = 5f;

    private Vector3 targetPosition;

    private bool isMoving;
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                targetPosition.z = 0f;
                isMoving = true;
            }
        }

        if (isMoving)
        {
            float step = _speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            if(transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }
}
