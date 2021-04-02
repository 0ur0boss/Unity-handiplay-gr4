using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour 
{
    public Rigidbody2D rb2D;
    public int Speed = 25;

    public void MovingRight()
    {
        if (Input.GetAxis("Horizontal") > 0f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * Speed);
        }
    }


    void FixedUpdate()
    {
        MovingRight();
    }
}
