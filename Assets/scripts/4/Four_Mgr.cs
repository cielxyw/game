using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Four_Mgr : MonoBehaviour
{
    public static Four_Mgr instance;
    public SpriteRenderer bgSprite;
    public int curIndex;
    public Animator eatCapAni;
    public List<GameObject> btns;
    public GameObject Area;
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

    public void OnClick(int i)
    {
        if (i == 1) //Ctrl
        {
            PanelMgr.instance.SetPanel("Tex/3/1", "Fire Control Room: There are standing professional staff to supervise the fire safety of the community, and can quickly grasp the fire situation to help control the fire. 50% reduction in fire value immediately after establishment. Do you want to use 1 bottle cap to establish this spot?");
            curIndex = 1;
        }
        else if (i == 2) //Road
        {
            PanelMgr.instance.SetPanel("Tex/3/2", "Fire Climbing Surface: Firefighting facilities in front of the block floors, where firefighters can quickly reach the fire scene. 100% reduction in the cost of time for extinguishing fire after establishment. Do you want to use 1 bottle cap to establish this spot?   ");
            curIndex = 2;
        }
        else if (i == 3) //High
        {
            PanelMgr.instance.SetPanel("Tex/3/3", "Fire Fighting Access: Emergency access reserved for fire engines, all the way clear. Remove all private cars from the road of the community immediately after establishment. Do you want to use 1 bottle cap to establish this spot?");
            curIndex = 3;
        }
    }

    public void UseCap()
    {
        eatCapAni.SetTrigger("EatCap");
        CapMgr.instance.AddCaps(-1);
        Debug.Log("使用了瓶盖，但是被物业海鸥拿走了");
        btns[curIndex - 1].SetActive(false);
        if (CapMgr.instance.curCaps <= 0)
        {
            Area.SetActive(false);
        }
        PanelMgr.instance.HidePanel();
    }
    
    public void DontUseCap()
    {
        PanelMgr.instance.HidePanel();
    }
}
