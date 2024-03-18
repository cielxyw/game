using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Truck : MonoBehaviour
{
    public void End()
    {
        PanelMgr.instance.SetPanel("Tex/End", "");
        PanelMgr.instance.subItem.SetActive(false);
    }

    public void Move()
    {
        Debug.Log("Truck Move");
        GetComponent<Animator>().SetBool("Move", true);
    }
}
