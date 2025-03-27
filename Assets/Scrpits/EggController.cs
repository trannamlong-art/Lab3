using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("MatDat"))
        {
            GameObject brokenEgg = Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.05f);
        }
        if (col.gameObject.name.Equals("NguoiNongDan"))
        {
            Destroy(gameObject);
        }

    }
}
