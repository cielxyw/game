using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class One_Statue : MonoBehaviour
{
    public static One_Statue instance;
    
    public int curLevel = 11;
    public int maxLevel = 2;
    public TextMeshProUGUI text;
    public Animator levelMask;
    public TextMeshProUGUI levelText;
    public SpriteRenderer bgSprite;
    public List<ObstacleSpawner> firstSpawner; //low
    public float firstSpeedUp;
    public float firstSpawnInterval;
    
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
            int curLayer = curLevel;
            levelText.text = curLayer.ToString();
            levelMask.SetTrigger("NextLevel");

            foreach (var spawner in firstSpawner)
            {
                spawner.obstacleSpeed += firstSpeedUp;
                spawner.spawnInterval += firstSpawnInterval;
            }

        }
        else
        {
            GameMgr.instance.NextLevel();
        }
    }

    public void ChangeLevelBg()
    {
        int curLayer = curLevel;
        bgSprite.sprite = Resources.Load<Sprite>("Tex/" + curLayer);
    }
}
