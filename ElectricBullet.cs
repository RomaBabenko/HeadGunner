using UnityEngine;

public class ElectricBullet : MonoBehaviour
{
    
    public float damage;
    public GameObject decal;

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        DeathZombie enemy = hitInfo.GetComponent<DeathZombie>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            GameObject d = Instantiate(decal, transform.position, transform.rotation);
            Destroy(d, 10f);
        }
        Destroy(gameObject);
    }

     void Update()
    {
        Destroy(gameObject, 0.3f);
    }
}
