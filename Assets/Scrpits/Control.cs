using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject prefabCircle;
    public GameObject prefabSquare;
    public GameObject prefabTriangle;
    // Start is called before the first frame update
    void Start()
    {
        GameObject square = GameObject.FindWithTag("square");
        if (square != null )
        {
            square.transform.position = new Vector2(1, 2);
            square.transform.eulerAngles = new Vector3(0, 0, 45);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 Circle = new Vector2(1f, 1f);
            GameObject a = Instantiate(prefabCircle, Circle, Quaternion.identity);
            Destroy(a, 1);
        }
       
    }
}
