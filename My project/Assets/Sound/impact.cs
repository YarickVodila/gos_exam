using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class impact : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // �������� ��������� AudioSource, ������������� � �������
        audioSource = GetComponent<AudioSource>();
    }

    // ���� ����� ����������, ����� ���������� ������������
    void OnCollisionEnter(Collision collision)
    {
        // ��������� ���� �����, ���������� magnitude ������������� �������� �����
        // ���������, ��� � ������� ������� ������������ ���� Rigidbody
        float impactForce = collision.relativeVelocity.magnitude;

        // ���������� ����������� ��������� ���� �����, ����� ������������� ���������
        // ��� �������� ����� ��������� ����������������, � ����������� �� ����� ����
        float maxImpactForce = 10f;

        // ����������� ��������� ����� ��� ��������� ���� ����� � ����������� ��������� ����
        // ����������� Mathf.Clamp, ����� �������� ��������� ������ ���������� � �������� [0, 1]
        float volume = Mathf.Clamp(impactForce / maxImpactForce, 0f, 1f);

        // ���������� ��������� AudioSource � �������������� ����
        audioSource.volume = volume;
        Debug.Log("���� ���������" + audioSource.volume);
        audioSource.Play();
    }
}
