using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    public float lifeTime = 5.0f;

    public bool Use = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Use)
        {
            Destroy(this.gameObject, lifeTime);
        }
    }
}
