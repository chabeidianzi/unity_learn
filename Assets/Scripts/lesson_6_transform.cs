using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_6_transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v = new Vector3 (0.0f, 0.0f, 0.0f);
        v.x = 10.0f;
        Vector3 v2 = new Vector3(4, 6, 7);

        //�����������ϵ��λ�� �Ǻ������ʾ�Ĳ�һ��
        this.transform.position = v;

        //����ڸ������λ��
        this.transform.localPosition = v2;

        //λ��ֻ������ı�
        this.transform.position = new Vector3(10,10,10);

        //�泯��
        print(this.transform.forward);
        print(this.transform.up);


        //����λ�� ·��= ����*λ��*ʱ��
        //ÿһ֡���ü���
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform .position = this.transform.position + this.transform.forward*1*Time.deltaTime;
        this.transform.position += Vector3.forward * 1 * Time.deltaTime;

        //api �ƶ�
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime,Space.World);//�������������ϵȥ��


    }
}
