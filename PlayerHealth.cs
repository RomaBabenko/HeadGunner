using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public float health;
    public Animator anim;
    public GameOver gameOver;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Zombie(Clone)")
        {
            health -= 1;
            
            if (health < 1)
            {
                anim.SetBool("death", true);
                gameOver.GameOverScreen();
                Destroy(gameObject, 2f);
            }
        }
    }
}



