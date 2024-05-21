using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_3_mono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 重要成员和方法
        // 获取依附的gameobject 获取位置信息 获取是否激活
        #endregion
        print(this.gameObject.name);
        print(this.transform.position);
        print(this.transform.eulerAngles);

        // 1得到自己挂载的单个脚本 根据脚本名 根据type 根据泛型  2得到自己挂载的多个脚本 3得到子对象挂载的脚本 4 得到父对象挂载的脚本 5 尝试获取脚本

        lesson_3_test t = this.GetComponent("Lesson3_test") as lesson_3_test;
        print(t);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
