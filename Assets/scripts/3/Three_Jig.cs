using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Jig : MonoBehaviour
{
    public Vector3 defaultPosition; 
    public int jigIndex = 0;
    public bool canDrag = true;
    private void Start()
    {
        defaultPosition = this.gameObject.transform.position;
    }

    public void OnDrag()
    {
        if (!canDrag)
        {
            return;
        }

        this.gameObject.transform.position = Input.mousePosition;
    }
    
    public void OnRelease()
    {
        if (!canDrag)
        {
            return;
        }

        Vector3 tarPos = Three_JigMgr.instance.GetJigPos(jigIndex);
        if(tarPos == Vector3.zero)
        {
            this.gameObject.transform.position = defaultPosition;
            return;
        }
        float distance = Vector3.Distance(tarPos, this.gameObject.transform.position);
        if (distance < Three_JigMgr.instance.correctDistance)
        {
            this.gameObject.transform.position = tarPos;
            Three_JigMgr.instance.SetJigCorrect(jigIndex);
            canDrag = false;
        }
        else
        {
            this.gameObject.transform.position = defaultPosition;
        }
    }
}
