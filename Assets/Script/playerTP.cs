using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTP : MonoBehaviour
{
    public GameObject plateform;
    [SerializeField]
    Transform[] sp;

    // Start is called before the first frame update
    public void Start()
    {
    }

    public void SpawnPlateform()
    {
        plateform.transform.position = sp[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            SpawnPlateform();
        }
    }
}
