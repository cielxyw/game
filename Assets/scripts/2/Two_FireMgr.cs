using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_FireMgr : MonoBehaviour
{
    public static Two_FireMgr instance;
    public List<GameObject> fires;
    private void Awake()
    {
        instance = this;
    }

    public void SetFire(bool show, int index)
    {
        if(fires.Count <= index)
            return;
        fires[index].SetActive(show);
        if (!show)
        {
            AudioMgr.instance.LoadAudioClip("OutFire");
            Three_Mgr.instance.leftFire--;
        }
    }
}
