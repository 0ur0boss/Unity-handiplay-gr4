using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public float chrono = 0f;
    public string message = "HelloWorld";


    // Start is called before the first frame update
    void Start()
    {
        chrono = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        chrono = chrono + Time.deltaTime;

        if (chrono > 5f)
        {
            Debug.Log(message); 
            chrono = 0f;
        }

    } 
}
