using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_4_gameobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //静态方法
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "我创建的立方体";
        
        //查找对象
        GameObject obj2 = GameObject.Find(obj.name); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
