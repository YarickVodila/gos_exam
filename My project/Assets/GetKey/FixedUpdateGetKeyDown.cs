using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateGetKeyDown : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // ��������� ����� ������������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forceAmount);
        }
    }
}