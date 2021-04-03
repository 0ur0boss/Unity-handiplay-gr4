using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPlus : MonoBehaviour
{
    Vector2 temp;
    public int compteur = 0;
   public bool status = true;
void Update(){
    
    if(compteur == 0)
    {
    print(compteur);
    status = false;
    }

    else if (compteur == 300)
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


