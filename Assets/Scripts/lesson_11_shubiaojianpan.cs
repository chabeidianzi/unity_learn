using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_11_shubiaojianpan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������updata��
        print(Input.mousePosition);//��Ļ����ԭ�������½� ����Ϊx�� ��Ϊy��
        //����ֵΪvectory3

        //��갴��һ˲�� 0 �� 1 �� 2 ��
        if (Input.GetMouseButtonDown(0)) {
            print("zuo an xia");
        }

        //����
        if (Input.GetKeyDown(KeyCode.W)) {
            print("w ����");
        }
    }
}
