using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPoint;
    public bool Right = true;
    public float spawnInterval = 3f;
    public float obstacleSpeed = 4f;

    private float cureSpawnInterval;
    private float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnInterval;
        cureSpawnInterval = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        
        if (spawnTimer >= cureSpawnInterval)
        {
            SpawnObstacle();
            spawnTimer = 0f;
            cureSpawnInterval = Random.Range(spawnInterval - 0.2f, spawnInterval + 0.5f);
            cureSpawnInterval = Mathf.Clamp(cureSpawnInterval, 0.1f, 3f);
        }
    }
    void SpawnObstacle()
    {
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
        obstacle.GetComponent<LifeTime>().Use = true;
        Rigidbody2D obstacleRigidbody = obstacle.GetComponent<Rigidbody2D>();
        obstacleRigidbody.velocity = (Right ? Vector2.right : Vector2.left) * obstacleSpeed;
        One_Statue.instance.obstacles.Add(obstacle);
    }
}
