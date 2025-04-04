using UnityEngine;

public class circle23 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;
    void Update()
    {
        Vector3 movement = new Vector3(0, direction, 0);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (transform.position.y <= -4.1 || transform.position.y >= -1.1)
        {
            direction *= -1;
        }
    }
}
