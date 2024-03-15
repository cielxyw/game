using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class One_Statue : MonoBehaviour
{
    public static One_Statue instance;
    
    public int curLevel = 0;
    public int maxLevel = 2;
    public TextMeshProUGUI text;
    public Animator levelMask;
    public TextMeshProUGUI levelText;
    public SpriteRenderer bgSprite;
    public ObstacleSpawner firstSpawner; //low
    public ObstacleSpawner secondSpawner; //high
    public float firstSpeedUp;
    public float secondSpeedUp;
    public float firstSpawnInterval;
    public float secondSpawnInterval;
    
    public List<GameObject> obstacles = new List<GameObject>();
    
    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel()
    {
        if(curLevel < maxLevel)
        {
            //销毁所有障碍物
            foreach (var obstacle in obstacles)
            {
                Destroy(obstacle);
            }
            obstacles.Clear();
            
            curLevel++;
            int curLayer = curLevel + 11;
            levelText.text = curLayer.ToString();
            levelMask.SetTrigger("NextLevel");
            //speed up the obstacle
            firstSpawner.obstacleSpeed += firstSpeedUp;
            secondSpawner.obstacleSpeed += secondSpeedUp;
            //spawn interval
            firstSpawner.spawnInterval *= firstSpawnInterval;
            secondSpawner.spawnInterval *= secondSpawnInterval;
        }
        else
        {
            Debug.Log("Next Level");
        }
    }

    public void ChangeLevelBg()
    {
        int curLayer = curLevel + 11;
        bgSprite.sprite = Resources.Load<Sprite>("Tex/" + curLayer);
    }
}
