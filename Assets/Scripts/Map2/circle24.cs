using UnityEngine;

public class circle24 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;
    void Update()
    {
        Vector3 movement = new Vector3(0, direction, 0);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (transform.position.y <= 1.2 || transform.position.y >= 4)
        {
            direction *= -1;
        }
    }
}