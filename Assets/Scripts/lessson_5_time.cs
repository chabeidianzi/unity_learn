using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessson_5_time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0;//ֹͣ
        Time.timeScale += 1;//�ָ�����
        //֡���ʱ�� �����һ֡���˶೤ʱ�� ��scaleӰ��
        print(Time.deltaTime);
        //����Ӱ��
        print(Time.unscaledDeltaTime);
        //֡���ʱ����������λ�� ·��=ʱ��*�ٶ�



        //y��Ϸ��ʼ�����ڵ�ʱ��
        print(Time.time);//������ʱ
        print(Time.unscaledTime);


        
    }
}
