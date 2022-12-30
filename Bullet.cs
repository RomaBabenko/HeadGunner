using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public GameObject decal;

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        damage = Random.Range(5, 20);
        DeathZombie enemy = hitInfo.GetComponent<DeathZombie>();

        if (enemy != null)
        {
            Destroy(gameObject);
            enemy.TakeDamage(damage);
            GameObject d = Instantiate(decal, transform.position, transform.rotation);
            Destroy(d, 10f);
        }
        Destroy(gameObject, 1f);
    }
}
