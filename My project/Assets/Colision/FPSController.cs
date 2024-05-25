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
        // Получить ввод с клавиатуры для передвижения вперёд/назад и влево/вправо
        float forwardMovement = Input.GetAxis("Vertical") * speed;
        float sideMovement = Input.GetAxis("Horizontal") * speed;

        // Перемещение капсулы
        transform.Translate(sideMovement * Time.deltaTime, 0, forwardMovement * Time.deltaTime);

        // Вращение капсулы по горизонтали с помощью мыши
        float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, horizontalRotation, 0);

        // Вращение камеры (головы) по вертикали
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);

        Camera camera = GetComponentInChildren<Camera>();
        if (camera != null)
        {
            camera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        }
    }
}
