using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_1_shengmingzhouqi : MonoBehaviour
{
    // Start is called before the first frame update
    //1s =1000ms 1000ms/60=16.66ms

    #region
    //֡���� �������ں������� �������ں��� ֧�ּ̳ж�̨    
    #endregion

    protected virtual void Awake()//�����󱻵���ʱ�Ż��������������ƹ��캯��
    {
        //��ӡ��Ϣ
        //1.û�м̳�monobehaviorʱ
        Debug.Log("hello unity");
        Debug.LogError("������");
        Debug.LogWarning("����");
        //2�̳��� ��һ���̴߳�ӡ
        print("12345");
    }

    private void OnEnable()//�������󼤻��ʱ�����
    {
        
    }


    void Start()//��һ��֡����֮ǰִ��һ��  ���ڳ�ʼ����Ϣ�����awake��ǰ
    {
        
    }
    private void FixedUpdate()//��������֡���� ÿһ֡��ִ�� ���ʱ���������
    {
        
    }
    // Update is called once per frame
    void Update()//ÿ֡���� ��awake��� ��̬����������� ���ڴ�����Ϸ�����߼�
    {
        
    }
    private void LateUpdate()//��������������������� �������ĸ���
    {
        
    }
    private void OnDisable()//����ʧ���ʱ�����
    {
        
    }
    private void OnDestroy()//���ٵ���
    {
        
    }
}
