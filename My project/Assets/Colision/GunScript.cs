using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 100.0f;
    public float fireRate = 0.25f;
    private float fireCooldown;

    void Update()
    {
        if (fireCooldown > 0)
        {
            fireCooldown -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1") && fireCooldown <= 0)
        {
            // Вызывается ваш метод стрельбы
            FireGun();
            fireCooldown = fireRate;
        }
    }

    void FireGun()
    {
        // Создаём пулю на позиции и с ротацией пушки
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = transform.forward * bulletSpeed;
        Destroy(bullet, 5.0f);
        /*        RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                    Debug.Log("Попадание по: " + hit.transform.name); // Здесь можно добавить логику урона
                }*/
    }
}
