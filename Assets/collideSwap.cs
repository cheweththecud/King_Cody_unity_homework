using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideSwap : MonoBehaviour {

    private Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Color color = Random.ColorHSV();
        rend.material.SetColor("_Color", color);
    }
}
