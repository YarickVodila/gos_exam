using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColExit : MonoBehaviour
{
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Contact Exit");
            // ��� ����� ���� �����, ���� �����, ��������� ����� � ��� �����.
        }
    }
}
