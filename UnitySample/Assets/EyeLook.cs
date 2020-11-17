using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLook : MonoBehaviour
{
    private Vector2 mD;
    public Transform head;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mC = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mD += mC;
        print(mD.x + ":" + mD.y);
        head.localRotation = Quaternion.AngleAxis(-mD.y, Vector3.right);
        this.transform.localRotation = Quaternion.AngleAxis(mD.x, Vector3.up);
    }
}
