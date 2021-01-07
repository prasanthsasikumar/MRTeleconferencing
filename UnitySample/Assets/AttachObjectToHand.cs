using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObjectToHand : MonoBehaviour
{
    public Transform source;
    public bool keepAttached = true;
    void Start()
    {
        
    // Start is called before the first frame update
    }

    // Update is called once per frame
    void Update()
    {
        if(keepAttached)
            this.transform.SetPositionAndRotation(source.position, source.rotation);
    }

    public void Attach()
    {
        keepAttached = true;
    }

    public void Dettach()
    {
        keepAttached = false;
    }
}
