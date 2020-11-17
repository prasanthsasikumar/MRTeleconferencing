using UnityEngine;
using System.Collections;

public class DemoRPGMovement : MonoBehaviour 
{
    public RPGCamera Camera;

    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
        Vector3 position = Camera.transform.position;

        GameObject newPlayerObject = PhotonNetwork.Instantiate("PlayerM", position, Quaternion.identity, 0 );
        GameObject SquishyPhoton = PhotonNetwork.Instantiate("SquishyPhoton", position, Quaternion.identity, 0);

        Camera.Target = newPlayerObject.transform;
    }
}
