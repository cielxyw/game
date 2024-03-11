using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zero_CapUse : MonoBehaviour
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
        Debug.Log("Scene 0 Cap Used!");
        Zero_Statue.instance.SetCap();
        Destroy(this.gameObject);
        return true;
    }
}
