using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_3_mono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ��Ҫ��Ա�ͷ���
        // ��ȡ������gameobject ��ȡλ����Ϣ ��ȡ�Ƿ񼤻�
        #endregion
        print(this.gameObject.name);
        print(this.transform.position);
        print(this.transform.eulerAngles);

        // 1�õ��Լ����صĵ����ű� ���ݽű��� ����type ���ݷ���  2�õ��Լ����صĶ���ű� 3�õ��Ӷ�����صĽű� 4 �õ���������صĽű� 5 ���Ի�ȡ�ű�

        lesson_3_test t = this.GetComponent("Lesson3_test") as lesson_3_test;
        print(t);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
