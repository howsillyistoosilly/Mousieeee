using UnityEngine;

public class DraggingScript : MonoBehaviour
{
    [SerializeField] private bool isDragging = false;
    public Rigidbody2D rb2d;
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chez"))
        {
            collision.gameObject.SetActive(false);
        }
    }

}
