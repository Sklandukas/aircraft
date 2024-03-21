using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfTheBounds : MonoBehaviour
{
    private float y1 = -8.2f;
    private float y2 = 8.2f;

    private float x1 = -17.4f;
    private float x2 = 15.4f;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y > y2)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < y1)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < x1)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > x2)
        {
            Destroy(gameObject);
        }
    }
}