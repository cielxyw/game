using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two_Extinguisher : MonoBehaviour
{
    public float subFireValue = 10;
    public GameObject hydrant;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<DragItem>().onUseItem += OnUse;
        this.GetComponent<DragItem>().onUseSpeItem += OnUseSpe;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public bool OnUse(int i)
    {
        Debug.Log("Scene 2 Extinguisher Used!");
        
        if (i < 0)
        {
            return false;
        }
        
        Two_FireMgr.instance.SetFire(false, i);
        if (FireValueMgr.instance)
        {
            FireValueMgr.instance.SubFireValue(subFireValue);
        }

        return false;
    }
    
    public bool OnUseSpe()
    {
        Debug.Log("Scene 3 Extinguisher Used!");
        hydrant.GetComponent<Three_Hydrant>().Broken();

        return false;
    }

}
