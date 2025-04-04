using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smartcircle : MonoBehaviour
{
    public GameObject prefabToSpawm;
    public GameObject player;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        count++;
        if(count > 300)
        {
            //Instantiate(prefabToSpawm, transform.position, Quaternion.identity);
            Vector3 direction = (player.transform.position - prefabToSpawm.transform.position).normalized;
            prefabToSpawm.GetComponent<Rigidbody2D>().velocity = direction * 2f;
        }
    }
}
