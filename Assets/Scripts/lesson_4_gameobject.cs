using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_4_gameobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //��̬����
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "�Ҵ�����������";
        
        //���Ҷ���
        GameObject obj2 = GameObject.Find(obj.name); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
