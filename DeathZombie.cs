using UnityEngine;

public class DeathZombie : MonoBehaviour
{
    public float health = 10f;
    private Score score;
    private MoneyGame moneyGame;
    public GameObject deathZombie;
    public AudioSource audioSource;
    public GameObject zombie;

    void Start()
    {
        score = FindObjectOfType<Score>();
        moneyGame = FindObjectOfType<MoneyGame>();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        audioSource.Play();

        if (health <= 0)
        {
            Destroy(gameObject);
            score.Kill();
            moneyGame.Coin();
            GameObject death = Instantiate(deathZombie, transform.position, transform.rotation);
            Destroy(death, 5f);
        }
    }
}
