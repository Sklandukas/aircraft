using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponGreen : MonoBehaviour
{
    public Transform firePoint;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Shoot();
        }
    }

    void Shoot ()
    {

    }
}
