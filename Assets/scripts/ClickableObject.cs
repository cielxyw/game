using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
  
    public GameObject itemDescription; // ��Ʒ˵������
    private bool isDescriptionVisible = false;

    void Start()
    {
        // �ڿ�ʼʱ����Ʒ˵������Ϊ���ɼ�
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


