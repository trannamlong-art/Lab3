using UnityEngine;

public class circle21 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;  
    void Update()
    {
        Vector3 movement = new Vector3(0, direction, 0);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (transform.position.y <= -3 || transform.position.y >= 3)
        {
            direction *= -1;
        }
    }
}

