using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Three_ChangeExtImg : MonoBehaviour
{
    public float scale = 0.14f;
    private Sprite spriteDef;
    private Sprite spriteDrag;
    private void Start()
    {
        var textureDef = Resources.Load<Texture2D>("Tex/Level3_Ext");
        var textureDrag = Resources.Load<Texture2D>("Tex/Ext");
        spriteDef = Sprite.Create(textureDef, new Rect(0, 0, textureDef.width, textureDef.height), new Vector2(0.5f, 0.5f));
        spriteDrag = Sprite.Create(textureDrag, new Rect(0, 0, textureDrag.width, textureDrag.height), new Vector2(0.5f, 0.5f));
    }

    public void SetDefault()
    {
        GetComponent<Image>().sprite = spriteDef;
        GetComponent<Image>().SetNativeSize();
    }

    public void SetDrag()
    {
        GetComponent<Image>().sprite = spriteDrag;
        GetComponent<Image>().SetNativeSize();
    }
}
