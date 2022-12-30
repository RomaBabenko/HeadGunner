using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public GameObject enemyPrefab;
    [SerializeField] 
    private float interval;
    private float timer = 0f;

    void Update()
    {
        IntervalSpawn(); //проблема. меняется постоянно значение, а должно с каждым появлением
        timer += Time.deltaTime;
       
        if (timer >= interval)
        {
            timer = 0f;
            Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }

    void IntervalSpawn()
    {
        interval = Random.Range(3f, 5f);
    }
}