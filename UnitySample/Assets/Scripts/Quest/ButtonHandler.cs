using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class ButtonHandler : MonoBehaviour
{
    public UnityEvent AttachAction, DetachAction;
    bool PreviousRightButtonValue = false;


    List<InputDevice> leftControllers = new List<InputDevice>(), rightControllers = new List<InputDevice>();

    // Start is called before the first frame update
    void Start()
    {
        InputDeviceCharacteristics leftTrackedControllerFilter = InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.Left;
        InputDeviceCharacteristics rightTrackedControllerFilter = InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.Right;
        InputDevices.GetDevicesWithCharacteristics(leftTrackedControllerFilter, leftControllers);
        InputDevices.GetDevicesWithCharacteristics(rightTrackedControllerFilter, rightControllers);
    }

    // Update is called once per frame
    void Update()
    {

        if(rightControllers[0].TryGetFeatureValue(CommonUsages.primaryButton, out bool ButtonValue))
        {
            if (ButtonValue && !PreviousRightButtonValue)
            {
                Debug.Log(" Button Pressed");
                AttachAction.Invoke();
            }
            if (!ButtonValue && PreviousRightButtonValue)
            {
                Debug.Log(" Button Released");
                DetachAction.Invoke();
            }
            PreviousRightButtonValue = ButtonValue;
        }
    }
}
