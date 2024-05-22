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

        //相对世界坐标系的位置 是和面板显示的不一样
        this.transform.position = v;

        //相对于父对象的位置
        this.transform.localPosition = v2;

        //位置只能整体改变
        this.transform.position = new Vector3(10,10,10);

        //面朝向
        print(this.transform.forward);
        print(this.transform.up);


        //计算位移 路程= 方向*位移*时间
        //每一帧都得计算
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform .position = this.transform.position + this.transform.forward*1*Time.deltaTime;
        this.transform.position += Vector3.forward * 1 * Time.deltaTime;

        //api 移动
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime,Space.World);//相对于世界坐标系去动


    }
}
