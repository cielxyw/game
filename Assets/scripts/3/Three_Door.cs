using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Door : MonoBehaviour
{
    public float addFireValue = 10;
    public void OnClick()
    {
        Debug.Log("Click Door");
        if (FireValueMgr.instance)
        {
            Debug.Log("Fire Value Add :" + addFireValue);
            FireValueMgr.instance.AddFireValueByItem(addFireValue);
        }
    }
}
