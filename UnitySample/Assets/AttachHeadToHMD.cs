using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachHeadToHMD : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("VRCamera"); 
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.SetPositionAndRotation(camera.transform.position, camera.transform.rotation);
    }
}
