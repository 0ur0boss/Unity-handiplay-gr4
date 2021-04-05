using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStick : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject Stick;
    public StickPlus StickSpeed;

public GameObject StickClone;
    public StickPlusClone StickSpeed2;

    public int Speed = 10;
    Rigidbody2D m_rb2D;
    SpriteRenderer m_renderer;

    public bool departPlayer;

    public GameObject Player;
    void oui()
    {
        StickSpeed.Speed = 0;

        StickSpeed2.Speed = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        departPlayer = false;
        
        if(collision.CompareTag("Stick") || collision.CompareTag("PrefabStick"))  
        {
            rb2D.velocity = Vector2.zero;
            StickSpeed.Speed = 0;
            StickSpeed2.Speed = 0;
            oui();
            Debug.Log("Merguez");
            departPlayer = true;
            
        }
        if(departPlayer == true){
        Player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 150);
        departPlayer = false;
        StickSpeed.enabled = true;
        StickSpeed2.enabled = true;
        }
    }

    }
