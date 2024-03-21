using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Shoot();
        }
    }

    void Shoot ()
    {

    }
}
