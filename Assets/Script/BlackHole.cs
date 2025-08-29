using Unity.VisualScripting;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float GravForce = 100f;
    public GameObject Player;
    public Vector2 forceDir;
    public Vector2 NormalizedForceDir;
    public Rigidbody2D rigidbody2d;
    public GameObject rope;
    public bool BlackholeActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Mousie");
        rigidbody2d = Player.GetComponent<Rigidbody2D>();
        rope = GameObject.Find("Rope");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
          
                Debug.Log("Blackhole");
                BlackholeActive = true;
                rope.SetActive(false);
                forceDir = this.transform.position - Player.transform.position;
                NormalizedForceDir = forceDir.normalized;
                rigidbody2d.AddForce(NormalizedForceDir * GravForce, ForceMode2D.Force);
        
        
    }
}
