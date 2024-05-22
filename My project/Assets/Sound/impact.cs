using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class impact : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Получите компонент AudioSource, прикрепленный к объекту
        audioSource = GetComponent<AudioSource>();
    }

    // Этот метод вызывается, когда происходит столкновение
    void OnCollisionEnter(Collision collision)
    {
        // Получение силы удара, используем magnitude относительной скорости удара
        // Убедитесь, что у другого объекта столкновения есть Rigidbody
        float impactForce = collision.relativeVelocity.magnitude;

        // Определите максимально возможную силу удара, чтобы нормализовать громкость
        // Это значение нужно подобрать экспериментально, в зависимости от вашей игры
        float maxImpactForce = 10f;

        // Рассчитайте громкость звука как отношение силы удара к максимально возможной силе
        // Используйте Mathf.Clamp, чтобы значение громкости всегда находилось в пределах [0, 1]
        float volume = Mathf.Clamp(impactForce / maxImpactForce, 0f, 1f);

        // Установите громкость AudioSource и воспроизведите звук
        audioSource.volume = volume;
        Debug.Log("Звук мощностью" + audioSource.volume);
        audioSource.Play();
    }
}
