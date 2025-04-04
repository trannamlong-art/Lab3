using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3 (direction, 0, 0);
        transform.Translate(movement *  moveSpeed * Time.deltaTime);

        if(transform.position.x <= -3.6 ||  transform.position.x >= 5)
        {
            direction *= -1;
        }
    }
}
