using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 15.0f;

    void Update()
    {
        Vector3 movement = new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        transform.Translate(movement);
    }
}
