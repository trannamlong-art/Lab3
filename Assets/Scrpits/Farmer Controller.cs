using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Vector2 velocity = Vector2.left * speed;
            rb.velocity = velocity;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vector2 velocity = Vector2.right * speed;
            rb.velocity = velocity;
        }
    }
}
