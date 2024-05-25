using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSensitivity = 2.0f;
    private float verticalRotation = 0;

    void Update()
    {
        // �������� ���� � ���������� ��� ������������ �����/����� � �����/������
        float forwardMovement = Input.GetAxis("Vertical") * speed;
        float sideMovement = Input.GetAxis("Horizontal") * speed;

        // ����������� �������
        transform.Translate(sideMovement * Time.deltaTime, 0, forwardMovement * Time.deltaTime);

        // �������� ������� �� ����������� � ������� ����
        float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, horizontalRotation, 0);

        // �������� ������ (������) �� ���������
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);

        Camera camera = GetComponentInChildren<Camera>();
        if (camera != null)
        {
            camera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        }
    }
}
