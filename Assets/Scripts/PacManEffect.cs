using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManEffect : MonoBehaviour
{
    public float min_x = -19.5f;
    public float max_x = 19.5f;
    public float min_y = -11.5f;
    public float max_y = 11.5f;

    void Update()
    {
        float y = transform.position.y;
        float x = transform.position.x;
        if (y > max_y || y < min_y)
        {
            transform.position = new Vector3(transform.position.x, -y, transform.position.z);
        }

        if (x > max_x || x < min_x)
        {
            transform.position = new Vector3(-x, transform.position.y, transform.position.z);
        }
        
    }
}
