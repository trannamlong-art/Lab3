using UnityEngine;

public class circle22 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;
    void Update()
    {
        Vector3 movement = new Vector3(direction, 0, 0);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (transform.position.x <= -5.5 || transform.position.x >= 6)
        {
            direction *= -1;
        }
    }
}