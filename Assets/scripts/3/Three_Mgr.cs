using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Mgr : MonoBehaviour
{
    public static Three_Mgr instance;
    public int leftFire;
    public bool isBroken;
    public int finishCount;
    public GameObject videoObj;
    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        leftFire = Two_FireMgr.instance.fires.Count;
    }

    public void FinishHyd()
    {
        finishCount++;
        if (finishCount >= 2)
        {
            //延迟1秒播放视频
            Invoke("DelayVideo", 1);
            Invoke("DelayNextLevel", 3);
        }
    }

    public void DelayVideo()
    {
        videoObj.SetActive(true);
        Three_Video.instance.videoPlayer.Play();
    }

    public void DelayNextLevel()
    {
        GameMgr.instance.NextLevel();
    }
}
