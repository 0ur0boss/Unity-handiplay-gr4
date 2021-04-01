using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject Player;
    private GameObject PlayerSpawn;
    
   public GameObject Script;
   PlayerBehavior PlayerScript;
    MovingRight speed;
   

    void Start()
    {
        PlayerScript = Script.GetComponent<PlayerBehaviour>();
        speed = 0f;
    }

   public void Update()
    {
        PlayerScript.MovingRight();
    }

    private void Awake()
    {
        playerSpawn = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collison.CompareTag("Player"))
        {
            Player.spawn.position = transform.position;
        }
    }

}