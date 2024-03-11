using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Mgr : MonoBehaviour
{
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
            PanelMgr.instance.SetPanel("Tex/Paper", "[Community fire control room] : Standing professional staff to supervise the community fire safety, can Get to know the fire quickly to help control it. Reduce fire value by 50% immediately after establishment.");
        }
        else if (i == 2) //Road
        {
            PanelMgr.instance.SetPanel("Tex/Paper", "[Fire passage] : Emergency passage reserved for fire engines, all the way unimpeded. Set up Immediately remove all private cars from the roads of the community.");

        }
        else if (i == 3) //High
        {
            PanelMgr.instance.SetPanel("Tex/Paper", "[Fire climbing surface] : the fire fighting facilities in front of the floor of the community, where the fire personnel can quickly Arrive at the fire scene. After establishment 119 fire extinguishing time -100%");
        }
    }

    public void UseCap()
    {
        Debug.Log("使用了瓶盖，但是被物业海鸥拿走了");
    }
    
    public void DontUseCap()
    {
        PanelMgr.instance.HidePanel();
    }
}
