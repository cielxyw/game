using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_JigMgr : MonoBehaviour
{
    public static Three_JigMgr instance;
    
    public float correctDistance = 0.5f;
    public List<Transform> jigPos;
    public List<bool> jigCorrect;
    private void Awake()
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

    public void SetJigCorrect(int i)
    {
        if(jigCorrect.Count > i)
        {
            jigCorrect[i] = true;
        }

        bool finish = true;
        foreach (var j in jigCorrect)
        {
            finish = finish && j;
            if (!finish)
            {
                break;
            }
        }

        if (finish)
        {
            Debug.Log("Next level!");
            //下一关
        }
    }
    
    public Vector3 GetJigPos(int i)
    {
        if(jigPos.Count > i)
        {
            return jigPos[i].position;
        }
        return Vector3.zero;
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
