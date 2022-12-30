using UnityEngine;

public class MovementForward : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Animator anim;

    void Start()
    {
        speed = Random.Range(0.4f, 1f);
    } 
    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player Control")
        {
            speed = 0f;
            anim.SetBool("attack", true);
        }
    }
}
