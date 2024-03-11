using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr instance;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }
}
