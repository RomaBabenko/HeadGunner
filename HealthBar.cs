using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image HealthBarPlayer;
    public float CurrentHealth;
    private float MaxHealth;
    PlayerHealth Player;

    void Start()
    {
        HealthBarPlayer = GetComponent<Image>();
        Player = FindObjectOfType<PlayerHealth>();
        MaxHealth = Player.health;
    }

    void Update()
    {
        CurrentHealth = Player.health;
        HealthBarPlayer.fillAmount = CurrentHealth / MaxHealth;
    }
}
