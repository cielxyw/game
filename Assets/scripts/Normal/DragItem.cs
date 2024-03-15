using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItem : MonoBehaviour
{
    public Vector3 defaultPosition;
    public List<RectTransform> InteractionItem;
    public RectTransform speInteractionItem;
    public delegate bool OnUseItem(int index = -1);
    public OnUseItem onUseItem;
    
    public delegate bool OnUseSpeItem();
    public OnUseSpeItem onUseSpeItem;

    public RectTransform selfTriArea;
    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag()
    {
        this.gameObject.transform.position = Input.mousePosition;
    }
    
    public void OnRelease()
    {
        int interItemIndex = -1;
        if (CheckInteraction(out interItemIndex))
        {
            if (onUseItem(interItemIndex))
            {
                return;
            }
        }
        
        Debug.Log("return " + this.name + " to default position");
        this.gameObject.transform.position = defaultPosition;
    }
    
    public bool CheckInteraction(out int num)
    {
        if (InteractionItem == null)
        {
            num = -1;
            return false;
        }
        
        Vector2 firstUIScreenSpace = Camera.main.WorldToScreenPoint(this.transform.position);
        if (selfTriArea != null)
        {
            firstUIScreenSpace = Camera.main.WorldToScreenPoint(selfTriArea.transform.position);
        }
        
        if (speInteractionItem != null)
        {
            bool isIntersecting = RectTransformUtility.RectangleContainsScreenPoint(speInteractionItem, firstUIScreenSpace, Camera.main);
            if (isIntersecting)
            {
                Debug.Log(this.name + " is intersecting with " + speInteractionItem.name + ": " + isIntersecting);
                onUseSpeItem();
                num = -1;
                return false;
            }  
        }
        
        for(int i =0;i < InteractionItem.Count; i++)
        { 
            bool isIntersecting = RectTransformUtility.RectangleContainsScreenPoint(InteractionItem[i], firstUIScreenSpace, Camera.main);
            if (isIntersecting)
            {
                num = i;
                Debug.Log(this.name + " is intersecting with " + InteractionItem[i].name + ": " + isIntersecting);
                return true;
            }  
        }
 
        num = -1;
        return false;
    }
}
