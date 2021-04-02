/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattonRotation : MonoBehaviour
{
    public GameObject stick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotation(Vector3.back * 1);
            Vector3 v = stick.transform.localRotation;
            v.z = v.z + 0.01f;
            stick.transform.localRotation = v;
        }
            
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattonRotation : MonoBehaviour
{
    public GameObject stick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("non");
            transform.Rotation(Vector3.back * 1);
           /* Vector3 v = stick.transform.Rotation;
            v.z = v.z + 0.01f;
            stick.transform.Rotation = v;*/
        }
    }
}