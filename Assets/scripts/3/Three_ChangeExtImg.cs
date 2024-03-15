using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Three_ChangeExtImg : MonoBehaviour
{
    public float scale = 0.14f;
    public void SetDefault()
    {
        this.transform.localRotation = Quaternion.identity;
        this.transform.localScale =  Vector3.one * scale;
    }

    public void SetDrag()
    {
        this.transform.localRotation = Quaternion.Euler(0, 0, 20);
        this.transform.localScale = new Vector3(-1,1,1) * scale;
    }
}
