using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_10_zuobiaohzuanhuan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ����������ϵ�ĵ�ת���Լ�������ϵ�� ������Ӱ��
        print("ת����ĵ�"+ this.transform.InverseTransformPoint(Vector3.forward));

        //��������Ӱ�� ������ת��
        print("ת����ĵ�" + this.transform.InverseTransformDirection(Vector3.forward));
        print("ת����ĵ�" + this.transform.InverseTransformVector(Vector3.forward));//��Ӱ��



        //��������ת��������
        print(this.transform.TransformPoint(Vector3.forward));//������Ӱ��
        print(this.transform.TransformVector(Vector3.forward));//��
        print(this.transform.TransformDirection(Vector3.forward));//����


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
