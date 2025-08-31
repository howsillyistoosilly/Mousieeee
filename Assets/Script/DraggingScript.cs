using System;
using UnityEngine;

public class DraggingScript : MonoBehaviour
{
    [SerializeField] private bool isDragging = false;

    public GameObject rope;
    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            if (rope.active)
            {
                transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
            }
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
