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
    public GameObject collectible;
    private Collectible collectibleScript;
    private bool isCollected;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collectibleScript = collectible.GetComponent<Collectible>();

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
        isCollected = collectibleScript.isCollected;
        if (isCollected)
        {
            speed = 0;
        }
        ypos = transform.position.y + speed * Time.deltaTime;
        transform.position = new Vector2(xpos, ypos);
    }
}
