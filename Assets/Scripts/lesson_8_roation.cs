using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_8_roation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        print(this.transform.eulerAngles);
        print(this.transform.localEulerAngles);
        this.transform.localEulerAngles = new Vector3(10,10,10);

        this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);//自转
        this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime,Space.World);//绕世界转

        //相对于一个点转
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);

    }
}
