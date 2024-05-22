using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColStay : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Contact Stay");
            // ��� ����� ���� �����, ���� �����, ��������� ����� � ��� �����.
        }
    }
}
