using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObjectToHand : MonoBehaviour
{
    public Transform source;
    public bool keepAttached = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(keepAttached)
            this.transform.SetPositionAndRotation(source.position, source.rotation);
    }
}
