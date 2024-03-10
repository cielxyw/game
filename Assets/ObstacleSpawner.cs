using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPoint;
    public float spawnInterval = 3f;
    public float obstacleSpeed = 4f;

    private float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        
        if (spawnTimer >= spawnInterval)
        {
            SpawnObstacle();
            spawnTimer = 0f;
        }
    }
    void SpawnObstacle()
    {
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);

        Rigidbody2D obstacleRigidbody = obstacle.GetComponent<Rigidbody2D>();
        obstacleRigidbody.velocity = Vector2.right * obstacleSpeed;
    }
}