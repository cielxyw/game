using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapMgr : MonoBehaviour
{
    public List<GameObject> caps;
    public int curCaps;
    public static CapMgr instance;
    private void Awake()
    {
        instance = this;
    }

    public void AddCaps(int i)
    {
        curCaps += i;
        for (int j = 0; j < 3; j++)
        {
            caps[j].SetActive(curCaps > j);
        }
    }
}
