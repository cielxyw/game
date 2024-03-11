using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class FireValueMgr : MonoBehaviour
{
    public static FireValueMgr instance;
    public float fireValue = 0;
    public float fireValueMax = 100;
    public float fireSpeed = 2;// person second

    public Slider slider;
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //重复执行 addFireValue 方法 fireSpeed 秒执行一次 0秒后开始执行
        InvokeRepeating("AddFireValue", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SubFireValue(float f)
    {
        fireValue -= f;
        if (fireValue <= 0)
        {
            fireValue = 0;
        }
        slider.value = fireValue;
    }

    public void AddFireValueByItem(float f)
    {
        fireValue += f;
        slider.value = fireValue;
        if (fireValue >= fireValueMax)
        {
            fireValue = fireValueMax;
            GameMgr.instance.GameOver();
        }
    }
    
    public void AddFireValue()
    {
        fireValue += fireSpeed;
        slider.value = fireValue;
        if (fireValue >= fireValueMax)
        {
            fireValue = fireValueMax;
            GameMgr.instance.GameOver();
        }
    }
}
