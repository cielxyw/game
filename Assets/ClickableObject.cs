using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
  
    public GameObject itemDescription; // 物品说明对象
    private bool isDescriptionVisible = false;

    void Start()
    {
        // 在开始时将物品说明设置为不可见
        HideItemDescription();
    }

    void OnMouseDown()
    {
        if (!isDescriptionVisible)
        {
            ShowItemDescription();
        }
        else
        {
            HideItemDescription();
        }
    }

    void ShowItemDescription()
    {
        itemDescription.SetActive(true);
        isDescriptionVisible = true;
    }

    void HideItemDescription()
    {
        itemDescription.SetActive(false);
        isDescriptionVisible = false;
    }

}


