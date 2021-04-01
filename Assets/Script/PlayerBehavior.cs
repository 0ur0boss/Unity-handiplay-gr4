using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour

{
    public float speed = 100f;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    public void MovingRight()
    {
        if (Input.GetAxis("Horizontal") > 0f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
        }

    }
    // Update is called once per frame
    public void Update()
    { 
            MovingRight();
    }
    void FixedUpdate()
    {
     
       
    }
}
