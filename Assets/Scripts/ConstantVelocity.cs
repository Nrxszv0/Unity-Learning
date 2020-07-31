using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //FixedUpdate is Called 100 times each second
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += new Vector3(0.5f,0,0);
    }
}
