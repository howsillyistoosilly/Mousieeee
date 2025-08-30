using UnityEngine;

public class CollisionRegion : MonoBehaviour
{
    public GameObject mousie;
    public GameObject asteroid0;
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject asteroid3;
    public GameObject asteroid4;

    private bool asteroidCollided = false;
    private bool mousieCollided = false;
    private GameObject currAsteroid;
    
    public GameObject rope;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
        
    // }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Collision");

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Mousie enter");
            mousieCollided = true;
        }

        if (collision.gameObject.tag == "Asteroid")
        {
            Debug.Log("Asteroid enter");
            asteroidCollided = true;
            currAsteroid = collision.gameObject;
        }

        if (asteroidCollided && mousieCollided )
        {
            Debug.Log("both enter");
            rope.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Mousie exit");
            mousieCollided = false;
        }

        if (collision.gameObject.tag == "Asteroid")
        {
            Debug.Log("Asteroid exit");
            currAsteroid = null;
            asteroidCollided = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
