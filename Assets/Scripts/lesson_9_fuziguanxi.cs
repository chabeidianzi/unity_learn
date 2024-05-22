using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson_9_fuziguanxi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(this.transform.parent.name);
        this.transform.parent = null;
        this.transform.parent = GameObject.Find("fathee").transform;
        this.transform.SetParent(null);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
