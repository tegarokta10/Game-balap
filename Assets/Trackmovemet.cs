using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trackmovemet : MonoBehaviour
{ 
    //Ini jelas kebutuhan taro variabel
    public float speed;
    Vector2 offset;

    // intinya disini tempat update main
    void Start()
    {
        
    }

    // Ini tempat update per frame dari game
    void Update()
    {
        {
        offset = new Vector2 (0, Time.time * speed);
        GetComponent <Renderer>().material.mainTextureOffset = offset;

        }
    }
}
