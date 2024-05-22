using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_10_zuobiaohzuanhuan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 将世界坐标系的点转到自己的坐标系下 受缩放影响
        print("转换后的点"+ this.transform.InverseTransformPoint(Vector3.forward));

        //不受缩放影响 的向量转换
        print("转换后的点" + this.transform.InverseTransformDirection(Vector3.forward));
        print("转换后的点" + this.transform.InverseTransformVector(Vector3.forward));//受影响



        //本地坐标转世界坐标
        print(this.transform.TransformPoint(Vector3.forward));//受缩放影响
        print(this.transform.TransformVector(Vector3.forward));//受
        print(this.transform.TransformDirection(Vector3.forward));//不受


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
