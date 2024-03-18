using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_End : MonoBehaviour
{
    public void End()
    {
        PanelMgr.instance.SetPanel("Tex/End", "");
        PanelMgr.instance.subItem.SetActive(false);
    }
}
