using RootMotion.FinalIK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToHMD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.GetComponent<VRIK>().solver.spine.headTarget = GameObject.Find("VRCameraOffset").transform;
            this.GetComponent<VRIK>().solver.leftArm.target = GameObject.Find("LeftHandOffset").transform;
            this.GetComponent<VRIK>().solver.rightArm.target = GameObject.Find("RightHandOffset").transform;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            this.GetComponent<VRIK>().solver.spine.headTarget = null;
            this.GetComponent<VRIK>().solver.leftArm.target = null;
            this.GetComponent<VRIK>().solver.rightArm.target = null;
        }
    }
}
