using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Four_CarDrag : MonoBehaviour
{
    public Vector3 startPos;

    public Vector3 forwardDir;
    public Vector3 starDragPos;

    public bool canDrag = true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        forwardDir = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnBeginDrag()
    {
        Debug.Log("OnBeginDrag");
        starDragPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        canDrag = true;
    }
    
    public void OnDrag()
    {
        if (!canDrag)
        {
            return;
        }

        Debug.Log("OnDrag");
        //只能朝着forwardDir方向拖动
        Vector3 dragPos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(dragPos);

        Vector3 dir = worldPos - startPos;
        dir.z = 0;
        Debug.Log("dir: " + dir);
        float dot = Vector3.Dot(dir.normalized, forwardDir);
        Debug.Log("dot: " + dot);
        if (dot > 0.85f && dot<1) //30度以内
        {
            //计算出dir在forwardDir方向上的投影
            float length = Vector3.Dot(dir, forwardDir);
            Debug.Log("1111: " + length);
            transform.position = startPos +  forwardDir * length;
        }
        if(dot<-0.85f && dot>-1) //150度~180
        {
            float length = Vector3.Dot(dir, -forwardDir);
            Debug.Log("2222: " + length);
            transform.position = startPos - forwardDir * length;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            Debug.Log("33333333333");
            this.transform.position = startPos;
            canDrag = false;
        }
        else if(other.CompareTag("Void"))
        {
            Debug.Log("444444444444");
            Destroy(this.gameObject);
        }
    }
}
