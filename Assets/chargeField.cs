using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chargeField : MonoBehaviour {

    //public GameObject post;
    int height= 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (height == 20) {
            Destroy(gameObject, 5);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name != "Terrain")
        {
            height += 1;
            for (int i = 1; i < height; i++)
            {
                print(i);
            }
        }
    }

    





    }
