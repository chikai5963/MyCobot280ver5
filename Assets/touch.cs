using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public grip G;
    public grip2 G2;

    public bool flag3;
    public bool flag4;

    public Transform transform_cube;
    public Transform transform_gripper;

    public Rigidbody Rcube;

    public Vector3 transform_position;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tos = null;
        tos = GameObject.Find("main_gripper");
        transform_gripper = tos.GetComponent<Transform>();
        transform_cube = this.transform;

        Rcube = this.GetComponent<Rigidbody>();

        transform_position.y = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        flag3 = G.flag;
        flag4 = G2.flag;

        if ((flag3 == true) && (flag4 == true)) {
            this.transform.SetParent(transform_gripper);
            Rcube.isKinematic = true;
        } else {
            this.transform.SetParent(null);
            Rcube.isKinematic = false;
        }
        
    }
}
