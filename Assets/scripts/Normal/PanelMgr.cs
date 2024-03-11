using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class PanelMgr : MonoBehaviour
{
    public static PanelMgr instance;
    public GameObject panel;
    public Image itemImg;
    public TextMeshProUGUI itemText;

    public GameObject other;

    private void Awake()
    {
        instance = this;
    }

    public void SetPanel(Sprite img, string text)
    {
        itemImg.sprite = img;
        itemText.text = text;
    }
    
    public void ShowPanel()
    {
        panel.gameObject.SetActive(true);
    }
    
    public void HidePanel()
    {
        //Destroy other下的所有子物体
        foreach (Transform child in other.transform)
        {
            Destroy(child.gameObject);
        }
        panel.gameObject.SetActive(false);
    }

    public void SetOtherPos(Vector3 pos)
    {
        other.transform.position = pos;
    }
}
