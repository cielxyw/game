using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_StepTwoItemUse : MonoBehaviour
{
    public GameObject HideOne;
    public GameObject HideTwo;
    public GameObject ShowOne;

    public bool playAudio = false;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<DragItem>().onUseItem += OnUse;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public bool OnUse(int index = -1)
    {
        if (!HideOne.activeInHierarchy || !HideTwo.activeInHierarchy)
        {
            return false;
        }

        HideOne.SetActive(false);
        HideTwo.SetActive(false);
        ShowOne.SetActive(true);
        if (playAudio)
        {
            AudioMgr.instance.LoadAudioClip("Metal");
        }

        Three_Mgr.instance.FinishHyd();
        return true;
    }
}
