using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject player;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Mousie");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
}
