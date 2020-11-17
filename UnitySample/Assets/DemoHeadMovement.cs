using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoHeadMovement : MonoBehaviour
{
    public RPGCamera Camera;

    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
        Vector3 position = Camera.transform.position;

        GameObject newPlayerObject = PhotonNetwork.Instantiate("TheRock", position, Quaternion.identity, 0);

        //Camera.Target = newPlayerObject.transform;
    }
}
