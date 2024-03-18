using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four_CarMgr : MonoBehaviour
{
    public static Four_CarMgr instance;
    public List<GameObject> cars;
    public GameObject truck;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            truck.GetComponent<Four_Truck>().Move();
        }
    }
    
    public void RemoveCar(GameObject go)
    {
        if (go != null && cars.Contains(go))
        {
            Destroy(go);
            cars.Remove(go);
        }

        if (cars.Count == 0)
        {
            truck.GetComponent<Four_Truck>().Move();
        }
    }
}
