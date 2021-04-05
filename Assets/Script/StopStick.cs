using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopStick : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject Stick;
    public StickPlus StickSpeed;
    public Rigidbody2D RigidbodyStickClone;
    public GameObject StickClone;
    public StickPlusClone StickSpeed2;

    public int Speed = 10;
    Rigidbody2D m_rb2D;
    Rigidbody2D m_rb2D2;
    SpriteRenderer m_renderer;
    public bool departPlayer;

    public GameObject Player;
    void oui()
    {
        StickSpeed.Speed = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        departPlayer = false;
        StickSpeed = GameObject.FindGameObjectWithTag("Stick").GetComponent<StickPlus>();
        
        if(collision.CompareTag("Stick") || collision.CompareTag("PrefabStick"))  
        {
            /*rb2D.velocity = Vector2.zero;*/
            StickSpeed.Speed = 0;
            oui();
            Debug.Log("Merguez");
            departPlayer = true;
            DestroyComponent();
        }
               
        if(departPlayer == true){
        Player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 150);
        departPlayer = false;
        StickSpeed.enabled = true;
        }

<<<<<<< HEAD
        /*SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);*/
=======
        /*else if (collision.gameObject.CompareTag("Stick")) {
            Debug.Log("Merguez");
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * Speed);
            
        /*float horizontalOffset = Input.GetAxis("Horizontal");
        float verticalOffset = Input.GetAxis("Vertical");
        if (Input.GetAxis("Horizontal") > 0f)
        {
            
        }
            
        }*/

      //SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
>>>>>>> cfdf32f24ddd622fd5738d93bfbcba0a68ed292e
    }
void DestroyComponent()
    {
        Destroy(GetComponent<Rigidbody2D>());
    }
    }
