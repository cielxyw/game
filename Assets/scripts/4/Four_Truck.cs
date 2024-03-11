using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_Truck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        Debug.Log("Truck Move");
        GetComponent<Animator>().SetBool("Move", true);
    }
}
