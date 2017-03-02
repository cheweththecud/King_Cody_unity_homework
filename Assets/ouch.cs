using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouch : MonoBehaviour
{
    public string reply = "ouch!";
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.name != "Terrain")
        {
            print(reply);
        }
    }
}