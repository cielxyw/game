using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Three_Hydrant : MonoBehaviour
{
    public GameObject jigsaw;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(!Three_Mgr.instance.isBroken)
            return;
        jigsaw.SetActive(true);
    }

    public void Broken()
    {
        if (Three_Mgr.instance.leftFire > 0)
        {
            return;
        }
        AudioMgr.instance.LoadAudioClip("GlassBroken");
        var brokenGlass = Resources.Load<Texture2D>("Tex/BrokenGlass");
        //Create Sprite
        Sprite paperSprite = Sprite.Create(brokenGlass, new Rect(0, 0, brokenGlass.width, brokenGlass.height), new Vector2(0.5f, 0.5f));
        img.sprite = paperSprite;
        img.color = new Color(1,1,1,1);
        Three_Mgr.instance.isBroken = true;
    }
}
