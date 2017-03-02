using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hop : MonoBehaviour {

    public float movementSpeed = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
    }
}
