using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }
    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging) {
            Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouseposition + offset;
        }
    }
}
