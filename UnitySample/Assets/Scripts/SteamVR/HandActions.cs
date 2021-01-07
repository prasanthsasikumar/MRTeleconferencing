using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandActions : MonoBehaviour
{
    [SerializeField]
    private float minDistanceToGrab = 0.2f;

    private DraggableObject[] draggables;

    private DraggableObject draggedObject = null;

    public GameObject desktopMonitor;

    // Start is called before the first frame update
    void Awake()
    {
        draggables = FindObjectsOfType<DraggableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerCliked()
    {
        float closestDistance = float.MaxValue;
        DraggableObject closestObject = null;
        print("pressed");

        foreach (DraggableObject draggable in draggables)
        {
            if (!draggable.IsDragged)
            {
                float distance = Vector3.Distance(draggable.transform.position, transform.position);

                if (distance < minDistanceToGrab && distance < closestDistance)
                {
                    closestDistance = distance;
                    closestObject = draggable;
                }
            }
        }

        if (closestObject != null)
        {
            draggedObject = closestObject;
            draggedObject.StartDragging(transform);
        }
    }

    public void OnTriggerUncliked()
    {
        print("released");
        if (draggedObject != null)
        {
            draggedObject.StopDragging();

            draggedObject = null;
        }
    }

    public void OnInteractUIPressed()
    {
        desktopMonitor.GetComponent<AttachObjectToHand>().keepAttached = true;
    }
    public void OnInteractUIReleased()
    {
        desktopMonitor.GetComponent<AttachObjectToHand>().keepAttached = false;
    }
}
