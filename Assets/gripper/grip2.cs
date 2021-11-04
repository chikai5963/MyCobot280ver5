using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class grip2 : MonoBehaviour
{
    //private SteamVR_Action_Single triggerpull = SteamVR_Actions.default_TriggerPull;

    public float pullright;

    public test T;

    public float po;
    public float si;
    public float tion;
    GameObject parent = null;
    Transform tra = null;

    public bool flag = false;

    void Update()
    {
        parent = transform.parent.gameObject;
        tra = parent.GetComponent<Transform>();
        po = tra.localPosition.x;
        si = tra.localPosition.y;
        tion = tra.localPosition.z;

        float ju;
        ju = T.trk;

        if (flag == false) {
            pullright = T.fuss;

            Vector3 pos = this.transform.localPosition;

            pos.x = po + (pullright * ju);
            pos.y = si;
            pos.z = tion;

            this.transform.localPosition = pos;
        }

        if (pullright > T.fuss) {
            pullright = T.fuss;

            Vector3 pos = this.transform.localPosition;

            pos.x = po + (pullright * ju);
            pos.y = si;
            pos.z = tion;

            this.transform.localPosition = pos;
        }

        //pullright = T.fuss;

        //pullright = triggerpull.GetLastAxis(SteamVR_Input_Sources.RightHand);
        //Debug.Log(pullright);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            flag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            flag = false;
        }
    }
}