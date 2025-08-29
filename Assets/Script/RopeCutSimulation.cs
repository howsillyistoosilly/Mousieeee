using Unity.VisualScripting;
using UnityEngine;

public class RopeCutSimulation : MonoBehaviour
{
    public GameObject rope;
     public GameObject spaceship;
     public Rigidbody2D rigidbody2d;
     public float ropedist;
     public float upperlim;
     public float lowerlim;
     public Vector2 ZeroGravMousie;
     public float RandomForce;
    

     public float ropeFracturePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        spaceship = GameObject.Find("SpaceShip");
        rope = GameObject.Find("Rope");
        rigidbody2d = GetComponent<Rigidbody2D>();
       

    }

    // Update is called once per frame
    void Update()
    {
        RandomForce = Random.Range(lowerlim, upperlim);
        
        ropedist = Mathf.Abs(this.transform.position.x - spaceship.transform.position.x);
        if ( ropedist >= (ropeFracturePoint) )
        {
            rope.SetActive(false);
            rigidbody2d.linearVelocity = new Vector3(RandomForce, RandomForce, RandomForce);
            rigidbody2d.freezeRotation = false;
        }
    }
}
