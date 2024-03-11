using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Zero_PaperUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<DragItem>().onUseItem += OnUse;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool OnUse(int i = 0)
    {
        Debug.Log("Scene 0 Paper Used!");
        if (Zero_Statue.instance.GetCap())
        {
            Do();
            return true;
        }
        else
        {
            Debug.Log("You need to use the cap first!");
            return false;
        }
        return false;
    }

    public void Do()
    {

        PanelMgr panelMgr = PanelMgr.instance;
        var paper = Resources.Load<Texture2D>("Tex/Paper");
        //Create Sprite
        Sprite paperSprite = Sprite.Create(paper, new Rect(0, 0, paper.width, paper.height), new Vector2(0.5f, 0.5f));
        //Set Panel
        panelMgr.SetPanel(paperSprite, "You got a stamp!");
        panelMgr.ShowPanel();
        //Create Stamp
        GameObject stamp = Resources.Load<GameObject>("Prefab/Stamp");
        GameObject stampInstance = Instantiate(stamp);
        stampInstance.transform.SetParent(panelMgr.other.transform);
        stampInstance.transform.localPosition = new Vector3(0, 0, 0);
        //Next Level
    }
}
