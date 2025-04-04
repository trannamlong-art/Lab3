using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("circle"))
        {
            Vector2 firstposition = new Vector2(-7, 2);
            transform.position = firstposition;
        }
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.Translate(movement * 5f *  Time.deltaTime);
    }
}
