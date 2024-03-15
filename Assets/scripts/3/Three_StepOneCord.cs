using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_StepOneCord : MonoBehaviour
{
    public GameObject StepTwo_Root;
    public void StepOne()
    {
        this.gameObject.SetActive(false);
        StepTwo_Root.SetActive(true);
    }
}
