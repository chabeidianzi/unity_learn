using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_1_shengmingzhouqi : MonoBehaviour
{
    // Start is called before the first frame update
    //1s =1000ms 1000ms/60=16.66ms

    #region
    //帧概念 生命周期函数概念 生命周期函数 支持继承多台    
    #endregion

    protected virtual void Awake()//当对象被调用时才会调用这个函数类似构造函数
    {
        //打印信息
        //1.没有继承monobehavior时
        Debug.Log("hello unity");
        Debug.LogError("出错了");
        Debug.LogWarning("警告");
        //2继承了 有一个线程打印
        print("12345");
    }

    private void OnEnable()//依附对象激活的时候调用
    {
        
    }


    void Start()//第一次帧更新之前执行一次  用于初始化信息相对于awake更前
    {
        
    }
    private void FixedUpdate()//用于物理帧更新 每一帧都执行 间隔时间可以设置
    {
        
    }
    // Update is called once per frame
    void Update()//每帧更新 与awake配合 动态创建对象更新 用于处理游戏核心逻辑
    {
        
    }
    private void LateUpdate()//用来处理摄像机更新内容 处理动画的更新
    {
        
    }
    private void OnDisable()//对象失活的时候调用
    {
        
    }
    private void OnDestroy()//销毁调用
    {
        
    }
}
