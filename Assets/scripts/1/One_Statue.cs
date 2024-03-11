using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_Statue : MonoBehaviour
{
    public static One_Statue instance;
    
    public int curLevel = 1;
    public int maxLevel = 3;
    
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
            curLevel++;
        }
        else
        {
            Debug.Log("Next Level");
        }
    }
}
