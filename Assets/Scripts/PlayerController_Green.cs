using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_player_Green : MonoBehaviour
{
    public float speed_x = 5.0f;
    private float currentSpeed = 5.0f;
    public float speed_y = 20.0f;
    public float rot_speed = 100.0f;
    public float bulletSpeed = 100;
    private float acceleration = 10.0f;
    private float deceleration = 5.0f;

    public Image GasBar;
    public GameObject clonePrefab;

    void Update()
    {
        Speed();

        if (Input.GetKey(KeyCode.LeftControl))
        {
            ResetRotation();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnNewObject();
        }
    }

    void ResetRotation()
    {
        if (transform.rotation.eulerAngles.z >= 140.0f && transform.rotation.eulerAngles.z <= 260.0f)
        {
            transform.Rotate(180f, 0f, 0f, Space.Self);
            transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }

    void SpawnNewObject()
    {
        GameObject newObject = Instantiate(clonePrefab, transform.position, Quaternion.identity);
        newObject.transform.eulerAngles = transform.eulerAngles;
    }

    void Speed()
    {
        float verticalInput = Input.GetKey(KeyCode.S) ? -1.0f : (Input.GetKey(KeyCode.W) ? 1.0f : 0.0f);

        if (GasBar.fillAmount > 0)
        {
            float targetSpeed = Input.GetKey(KeyCode.LeftShift) ? (speed_x + 15.0f) : speed_x;

            if (currentSpeed < targetSpeed)
            {
                currentSpeed += acceleration * Time.deltaTime;
            }
            else if (currentSpeed > targetSpeed)
            {
                currentSpeed -= deceleration * Time.deltaTime;
            }
        }
        else if (GasBar.fillAmount == 0)
        {
            currentSpeed -= deceleration * Time.deltaTime;
        }

        currentSpeed = Mathf.Clamp(currentSpeed, speed_x, 20.0f);

        Vector3 movement = new Vector3(-currentSpeed * Time.deltaTime, 0, 0);
        transform.Translate(movement);

        float pitchAmount = -verticalInput * rot_speed * Time.deltaTime;
        Vector3 newEulerAngles = transform.eulerAngles + new Vector3(0, 0, pitchAmount);
        transform.eulerAngles = newEulerAngles;
    }
}
