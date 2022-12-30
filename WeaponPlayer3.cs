using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPlayer3 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public Animator anim;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Shoot();
            anim.SetBool("rifle", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("rifle", false);
        }
    }
    void Shoot()
    {
        nextFire = Time.time + fireRate;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(firePoint.up, ForceMode2D.Impulse);

    }
}
