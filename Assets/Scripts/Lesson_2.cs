using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum E_TestEnum { 
    master,
    boss
}

[System.Serializable]//ʹ���Զ����������ʾ
public class Myclass {
    public int age;
    public int sex;
}


public class Lesson_2 : MonoBehaviour
{
    // Start is called before the first frame update
    //inspector ��ʾ�Ŀɱ༭���ݾ��ǽű��ĳ�Ա����

    //˽�б����޷��༭  ����[SerializeField]
    [SerializeField]
    private int age;
    [HideInInspector]//����
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
