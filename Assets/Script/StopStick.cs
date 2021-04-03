using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStick : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject Stick;
    public Stick StickSpeed;


    void Start()
    {

    }

   public void Update()
    {

    }

    void oui()
    {
        StickSpeed.Speed = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Stick"))  
        {
            //rb2D.velocity = Vector3.zero;
            oui();
            Debug.Log("test");
        }
    }

}