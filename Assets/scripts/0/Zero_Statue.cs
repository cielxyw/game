using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zero_Statue : MonoBehaviour
{
    public static Zero_Statue instance;
    public bool zero_useCap = false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public bool GetCap()
    {
        return zero_useCap;
    }
    
    public bool SetCap()
    {
        zero_useCap = true;
        return zero_useCap;
    }
    
    public void OnClick(int i)
    {
        if (i == 1) //Paper
        {
            var paper =GameObject.Find("Canvas/Paper");
            if (paper.GetComponent<DragItem>().defaultPosition == paper.transform.position)
            {
                PanelMgr.instance.SetPanel("Tex/Paper", "[Registration form] : The owner registration that needs to be submitted for residential occupancy Table, which records the basic information of the owner and the house number");
            }
        }
        else if (i == 2) //Cap
        {
            var cap =GameObject.Find("Canvas/Cap");
            if (cap.GetComponent<DragItem>().defaultPosition == cap.transform.position)
            {
                PanelMgr.instance.SetPanel("Tex/Paper", "[Bottle cap] : A golden bottle cap that seems to have changed little The power of district structure... ?");
            }
        }
    }
}
