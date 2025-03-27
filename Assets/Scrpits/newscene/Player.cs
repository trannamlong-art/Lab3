using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("circle"))
        {
            Vector2 firstposition = new Vector2(-6, 0);
            transform.position = firstposition;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.Translate(movement * 5f * Time.deltaTime);
    }
}
