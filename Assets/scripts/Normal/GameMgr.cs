using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    public static GameMgr instance;
    public int curLevel = 0;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void NextLevel()
    {
        Debug.Log("Next Level");
        if (curLevel > 0)
        {
            PanelMgr.instance.SetPanel("Tex/111", "");
            PanelMgr.instance.subItem.SetActive(false);
            //设置PanelMgr.instance.itemImg的rectTransform的长宽为2200,1000
            PanelMgr.instance.itemImg.rectTransform.sizeDelta = new Vector2(2200, 1000);
            
            Invoke("ChangeLevel",2);
        }
        else
        {
            ChangeLevel();
        }
    }

    public void ChangeLevel()
    {
        curLevel++;
        if (curLevel > 2)
        {
            CapMgr.instance.AddCaps(1);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        PanelMgr.instance.SetPanel("Tex/End", "");
        PanelMgr.instance.subItem.SetActive(false);
    }
}
