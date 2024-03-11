using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Car : MonoBehaviour
{
    public Vector3 lastPosition;
    public bool canDrag = true;
    public float force = 3000;

    private void Update()
    {
        //判断是否不在屏幕内
        if (this.gameObject.transform.position.x < 0 || this.gameObject.transform.position.x > Screen.width ||
            this.gameObject.transform.position.y < 0 || this.gameObject.transform.position.y > Screen.height)
        {
            Four_CarMgr.instance.RemoveCar(this.gameObject);
        }
    }
    
    public void OnDrag()
    {
        if (!canDrag)
        {
            return;
        }

        lastPosition = this.gameObject.transform.position;
        this.gameObject.transform.position = Input.mousePosition;
    }

    public void OnRelease()
    {
        //朝着最后一次位移方向飞出
        Vector3 dir = Input.mousePosition - this.gameObject.transform.position;
        if(dir.magnitude < 0.1f)
        {
            dir = Input.mousePosition - lastPosition;
        }
        Debug.Log(dir);
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(dir.normalized * force);
        canDrag = false;
    }
}
