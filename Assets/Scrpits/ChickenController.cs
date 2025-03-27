using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject egg;
    private int count = 0;
 
    void Update()
    {
        count++;
        if (count > 100)
        {
            Instantiate(egg, transform.position, Quaternion.identity);
            count = 0;
        }
    }
}
