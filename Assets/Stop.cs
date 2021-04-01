using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject Player;
    private GameObject PlayerSpawn;
    public PlayerBehavior playerSpeed;


    void Start()
    {

    }

   public void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))  
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

}