using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject mousie;
    public bool isCollected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        isCollected = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 50f * Time.deltaTime);
    }
}
