using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour
{
    private new Renderer renderer;

    void Start()
    {
        // Получаем компонент Renderer объекта, чтобы изменить его цвет
        renderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Проверяем, не пуля ли столкнулась с объектом
        if (collision.collider.CompareTag("Bullet"))
        {
            // Меняем цвет объекта на случайный
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
