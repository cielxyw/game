using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three_Ext : MonoBehaviour
{
    public GameObject hydrant;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<DragItem>().onUseItem += OnUse;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public bool OnUse(int i)
    {
        Debug.Log("Scene 3 Extinguisher Used!");
        hydrant.GetComponent<Three_Hydrant>().Broken();

        return false;
    }
}
