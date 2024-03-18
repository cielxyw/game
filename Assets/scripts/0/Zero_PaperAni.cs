using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zero_PaperAni : MonoBehaviour
{
    public void TurnPage()
    {
        bool curPage = this.GetComponent<Animator>().GetBool("TurnPage");
        this.GetComponent<Animator>().SetBool("TurnPage", !curPage);
    }
}
