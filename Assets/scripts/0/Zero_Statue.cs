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
}
