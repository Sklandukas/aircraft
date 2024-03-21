using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasManager_Green : MonoBehaviour
{
    public Image GasBar;
    public GameObject aircraft;
    public float maxGas = 100f;
    public float aircraftSpeed = 5.0f;
    public float gasDecreaseRate = 5.0f;

    float speed;

    private float currentGas;
    private float previousSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentGas = maxGas;
        previousSpeed = rb.velocity.magnitude;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentGas -= gasDecreaseRate * Time.deltaTime;
            GasBar.fillAmount = currentGas / 100f;
        }
        else
        {
            if (currentGas < maxGas)
            {
                currentGas += gasDecreaseRate * Time.deltaTime;
                GasBar.fillAmount = currentGas / 100f;
            }
        }
        currentGas = Mathf.Clamp(currentGas, 0f, maxGas);


    }
}
