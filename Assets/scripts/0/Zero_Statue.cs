using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zero_Statue : MonoBehaviour
{
    public static Zero_Statue instance;
    public bool zero_useCap = false;
    public Image bgImg;
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
                PanelMgr.instance.SetPanel("Tex/PaperUI", "");
                PanelMgr.instance.subItem.SetActive(true);
            }
        }
        else if (i == 2) //Cap
        {
            var cap =GameObject.Find("Canvas/Cap");
            if (cap.GetComponent<DragItem>().defaultPosition == cap.transform.position)
            {
                PanelMgr.instance.SetPanel("Tex/CapUI", "");
                PanelMgr.instance.subItem.SetActive(false);
            }
        }
    }
}
