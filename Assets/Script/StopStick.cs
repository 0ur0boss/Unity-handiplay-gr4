using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStick : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject Stick;
    public StickPlus StickSpeed;
    public int Speed = 25;
    public int SpeedRight = 100;
    Rigidbody2D m_rb2D;
    SpriteRenderer m_renderer;

    public bool departPlayer;

    public GameObject Player;


    void Start()
    {

    }

   public void Update()
    {

    }

    void oui()
    {
        StickSpeed.Speed = 0;
        departPlayer = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        departPlayer = false;
        
        if(collision.CompareTag("Stick"))  
        {
            rb2D.velocity = Vector2.zero;
            StickSpeed.Speed = 0;
            Debug.Log("Merguez");
            departPlayer = true;
            
        }
        if(departPlayer == true){
        Player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * SpeedRight);
        departPlayer = false;
        }

        /*else if (collision.gameObject.CompareTag("Stick")) {
            Debug.Log("Merguez");
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * Speed);
            
        /*float horizontalOffset = Input.GetAxis("Horizontal");
        float verticalOffset = Input.GetAxis("Vertical");
        if (Input.GetAxis("Horizontal") > 0f)
        {
            
        }
            
        }*/
    }

    }
