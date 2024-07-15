using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hijaumovement : MonoBehaviour
{
    public float Hijauspeed;
    public float maxPost = 2.2f;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position; // awal game berada di suatu posisi awal
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis ("Horizontal") * Hijauspeed * Time.deltaTime; // digunakan untuk perintah kiri dan kanan
        position.x = Mathf.Clamp (position.x, -maxPost, maxPost); // digunakan untuk mengatur batas  dari movment perintah
        transform.position = position; // menjalankan perintah sesuai posisi dari input
    }
    void onCollisionr2D(Collision2D col)
    {
        Destroy (gameObject);
        print ("Game Over Cuy");
    }
}
