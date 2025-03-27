using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlepro : MonoBehaviour
{
    public GameObject prefabtoSpawm;
    public GameObject player;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Collider2D myCollider = GetComponent<Collider2D>();
        Collider2D wallCollider = GameObject.Find("Map").GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(myCollider, wallCollider);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count > 300)
        {
            
            Vector3 direction = (player.transform.position - prefabtoSpawm.transform.position).normalized;
            prefabtoSpawm.GetComponent<Rigidbody2D>().velocity = direction * 2f;
        }
    }
}
