using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    private const int V = 0;
    public Rigidbody2D rb2D;
    public int Speed = 2;
    Rigidbody2D m_rb2D;
    SpriteRenderer m_renderer;
    public int tailleStick = 0;
    Vector2 temp;

   

    void Awake()
    {
        m_rb2D = gameObject.GetComponent<Rigidbody2D>();
        m_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {

            
    }


    // Update is called once per frame
    public void Update()
    {
    }
  /*float smooth = 2.0f;
            
            Vector2 newScale = new Vector2(0, 200); // Les dimensions souhaités
            transform.localScale = Vector2.Lerp(transform.localScale, newScale, Time.deltaTime * smooth);*/

        
        
        /*if (Input.GetKey(KeyCode.E))
        {
            
            transform.Rotate(Vector3.back * Speed);
        }*/

}