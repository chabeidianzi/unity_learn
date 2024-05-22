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
        Time.timeScale = 0;//停止
        Time.timeScale += 1;//恢复正常
        //帧间隔时间 最近的一帧用了多长时间 受scale影响
        print(Time.deltaTime);
        //不受影响
        print(Time.unscaledDeltaTime);
        //帧间隔时间用来计算位移 路程=时间*速度



        //y游戏开始到现在的时间
        print(Time.time);//用来计时
        print(Time.unscaledTime);


        
    }
}
