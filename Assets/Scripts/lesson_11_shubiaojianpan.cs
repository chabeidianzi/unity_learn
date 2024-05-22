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
        //输入在updata中
        print(Input.mousePosition);//屏幕坐标原点在左下角 往右为x正 上为y正
        //返回值为vectory3

        //鼠标按下一瞬间 0 左 1 右 2 中
        if (Input.GetMouseButtonDown(0)) {
            print("zuo an xia");
        }

        //键盘
        if (Input.GetKeyDown(KeyCode.W)) {
            print("w 按下");
        }
    }
}
