using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGetKeyDown : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Обработка ввода пользователя
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forceAmount);
        }
    }
}
