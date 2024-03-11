using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner2 : MonoBehaviour
{
    public GameObject obstacle2Prefab;
    public Transform spawnPoint2;
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
        GameObject obstacle = Instantiate(obstacle2Prefab, spawnPoint2.position, Quaternion.identity);
        obstacle.GetComponent<LifeTime>().Use = true;
        Rigidbody2D obstacleRigidbody = obstacle.GetComponent<Rigidbody2D>();
        obstacleRigidbody.velocity = Vector2.left * obstacleSpeed;
    }
}// Start is called before the first frame update
