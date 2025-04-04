using UnityEngine;

public class Player3 : MonoBehaviour
{
    public static int totalpoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("circle"))
        {
            Vector2 firstposition = new Vector2(7, 0);
            transform.position = firstposition;
        }
        if (collision.gameObject.CompareTag("point"))
        {
            Destroy(collision.gameObject);
            totalpoint--;
        }
    }
    private void Start()
    {
        GameObject[] point = GameObject.FindGameObjectsWithTag("point");
        totalpoint = point.Length;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.Translate(movement * 5f * Time.deltaTime);
    }
}