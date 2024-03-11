using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelTri : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            One_Statue.instance.NextLevel();
            player.instance.GetComponent<obstacle>().Die();
        }
    }
}
