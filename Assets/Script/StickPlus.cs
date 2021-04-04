using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPlus : MonoBehaviour
{
    Vector2 temp;
    public int compteur = 0;
   public bool status = true;
   public bool stopStick = false;
   public int Speed = 2;
    Rigidbody2D m_rb2D;
    SpriteRenderer m_renderer;
void Awake()
{
    m_rb2D = gameObject.GetComponent<Rigidbody2D>();
    m_renderer = gameObject.GetComponent<SpriteRenderer>();
}

void Update(){
    
if (Input.GetKeyDown(KeyCode.A))
{
stopStick = true;
}
if(stopStick == true)
{
    transform.Rotate(Vector3.back * Speed);
    return;
}

    if(compteur == 0)
    {
    print(compteur);
    status = false;
    }

    else if (compteur == 580)
    {
    print(compteur);
    status = true;
    }

    if (status == true)
    {
    temp = transform.localScale;
    temp.y -= Time.deltaTime;
    transform.localScale = temp;
    compteur--;
    }

    else if (status == false)
    {
    temp = transform.localScale;
    temp.y += Time.deltaTime;
    transform.localScale = temp;
    compteur++;
    }

    
}
}


