using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnCooldown = 2;
    public GameObject[] enemyObjects;
    public float minPos;
    public float maxPos;
    public float minSpeed;
    public float maxSpeed;
    private float timer;
    
    private void Start()
    {
        timer = 0;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer>= spawnCooldown)
        {
            timer = 0;
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        Vector3 randomposition = transform.position;
        randomposition.y = Random.Range(minPos, maxPos);

        int targetEnemyIndex = Random.Range(0, enemyObjects.Length);
        GameObject enemies = enemyObjects[targetEnemyIndex];

        GameObject enemy = Object.Instantiate(enemies, randomposition, transform.rotation);

        float randomspeed = Random.Range(minSpeed, maxSpeed);
        EnemyScript enemymove = enemy.GetComponent<EnemyScript>();
        enemymove.speed = randomspeed;
    }
}
