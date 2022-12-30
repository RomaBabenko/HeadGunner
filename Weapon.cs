 using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public Animator anim;
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Shoot();
            anim.SetBool("rifle", true);
            muzzleFlash.Play();
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("rifle", false);
            muzzleFlash.Stop();
        }
    }

    void Shoot()
    {
        nextFire = Time.time + fireRate;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}


