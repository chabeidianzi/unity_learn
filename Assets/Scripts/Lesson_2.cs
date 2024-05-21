using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum E_TestEnum { 
    master,
    boss
}

[System.Serializable]//使得自定义类可以显示
public class Myclass {
    public int age;
    public int sex;
}


public class Lesson_2 : MonoBehaviour
{
    // Start is called before the first frame update
    //inspector 显示的可编辑内容就是脚本的成员变量

    //私有保护无法编辑  加上[SerializeField]
    [SerializeField]
    private int age;
    [HideInInspector]//隐藏
    public int age2;

    public int[] array;
    public List<int> list;
    public E_TestEnum type;
    public GameObject gameobj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
