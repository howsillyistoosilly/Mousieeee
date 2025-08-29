using System;
using UnityEngine;

public class DraggingScript : MonoBehaviour
{
    [SerializeField] private bool isDragging = false;
    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseDown()
    {
        isDragging = !isDragging;
    }
    private void OnMouseUp()
    {
        isDragging = false;
    }
}
