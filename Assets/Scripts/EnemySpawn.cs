using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnCooldown = 2;
    public GameObject enemyObject;
    public float minPos;
    public float maxPos;
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
        Object.Instantiate(enemyObject, randomposition, transform.rotation);
    }
}
