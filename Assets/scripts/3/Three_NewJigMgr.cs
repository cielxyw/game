using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_NewJigMgr : MonoBehaviour
{
    public GameObject StepOne_Cord;
    public GameObject StepTwo_Root;
    public RectTransform StepTwo_Left;
    public RectTransform StepTwo_Right;
    public RectTransform StepTwo_LeftTar;
    public RectTransform StepTwo_RightTar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Step 1 Drag cords to diverge to two sides
    public void StepOne()
    {
        StepOne_Cord.SetActive(false);
        StepTwo_Root.SetActive(true);
    }
}
