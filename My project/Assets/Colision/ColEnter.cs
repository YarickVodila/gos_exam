using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColEnter : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Contact Enter");
            // ��� ����� ���� �����, ���� �����, ��������� ����� � ��� �����.
        }
    }
}
