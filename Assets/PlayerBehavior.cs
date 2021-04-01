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

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0f)
        {
            rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.left);
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.right);
        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.up);
        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.down);
        }
    }
}
