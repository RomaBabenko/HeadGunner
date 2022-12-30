using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] 
    public GameObject deathScreen;

    public void GameOverScreen()
    {
            if (!deathScreen.activeSelf)
            {
                Invoke("End", 2f);
            }
    }

    void End()
    {
       deathScreen.SetActive(true);
    }
}
