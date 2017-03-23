using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeDeath : MonoBehaviour {

    public float life = 100;
    public float dmg = 10;

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        if (collision.collider.name != "Terrain")
        {
            life -= dmg;
        }
        if (life < 0)
        {
            Destroy(gameObject);
        }
    }


}
