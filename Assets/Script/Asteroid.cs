using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // 0 for left, 1 for right
    public bool track;
    private float speed;
    private float xpos;
    private float ypos;
    public GameObject rope;
    public GameObject mousie;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (track)
        {
            speed = 4f;
            xpos = 0.8f;
        }
        else
        {
            speed = -4f;
            xpos = -3.6f;
        }
    }

    // bool isOutOfScreen()
    // {
    //     if (track)
    //     {

    //     }
    //     return false;
    // }

    private void OnBecameInvisible()
    {
        if (track)
        {
            transform.position = new Vector2(xpos, -10f);
        }
        else
        {
            transform.position = new Vector2(xpos, 10f);
        }
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     rope.SetActive(false);
    // }
    void Update()
    {
        ypos = transform.position.y + speed * Time.deltaTime;
        transform.position = new Vector2(xpos, ypos);
    }
}
