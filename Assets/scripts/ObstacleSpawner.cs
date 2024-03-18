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
        obstacleSpeed = Random.Range(obstacleSpeed - 1f, obstacleSpeed + 1f);
        obstacleSpeed = Mathf.Clamp(obstacleSpeed, 0.3f, 6f);
        obstacleRigidbody.velocity = (Right ? Vector2.right : Vector2.left) * obstacleSpeed;
        var curLevel = One_Statue.instance.curLevel;
        int maxKind = GetObstacleKind(curLevel);
        string path = "Tex/Obstacle/" + curLevel + "/" + curLevel + "0" + Random.Range(1, maxKind + 1);
        var texture =
            Resources.Load<Texture2D>(path);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        obstacle.GetComponent<SpriteRenderer>().sprite = sprite;
        One_Statue.instance.obstacles.Add(obstacle);
    }

    int GetObstacleKind(int curLevel)
    {
        switch (curLevel)
        {
            case 11:
                return 6;
            case 12:
                return 9;
            case 13:
                return 7;
        }

        return 0;
    }
}
