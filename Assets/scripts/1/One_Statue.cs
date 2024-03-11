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
            text.text = (curLevel + 12).ToString();
        }
        else
        {
            Debug.Log("Next Level");
        }
    }
}
