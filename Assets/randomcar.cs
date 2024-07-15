using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simerah : MonoBehaviour
{
    public float speed;
    float nilairandom;
    // Start is called before the first frame update
    void Start()
    {
        nilairandom = Random.Range (-3.7f, 2.2f);
        transform.position = new Vector2 (transform.position.x, nilairandom;)
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate (new Vector3 (0,1,0) * speed * Time.deltaTime);
       transform.position = Vector2.MoveTowards(transform.position,Vector2.left * 100,Time.deltaTime * 5 );
    }
}
