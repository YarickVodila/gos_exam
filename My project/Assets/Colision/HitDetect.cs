using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour
{
    private new Renderer renderer;

    void Start()
    {
        // �������� ��������� Renderer �������, ����� �������� ��� ����
        renderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // ���������, �� ���� �� ����������� � ��������
        if (collision.collider.CompareTag("Bullet"))
        {
            // ������ ���� ������� �� ���������
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
