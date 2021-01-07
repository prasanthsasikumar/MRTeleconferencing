using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineObject : MonoBehaviour {

	private float sensitivity = 100;//0.5f;

	// private Vector3 mouseReference;
	// private Vector3 mouseOffset;
	// private Vector3 rotation = Vector3.zero;
	// private bool isRotating = false;

	private Ray ray;
	private RaycastHit raycast;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(isRotating){
			mouseOffset = Input.mousePosition - mouseReference;
			mouseReference = Input.mousePosition;
			rotation = -mouseOffset * sensitivity;
			transform.eulerAngles += rotation;
		}*/
		/*ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out raycast, 1000)){
			if(Input.GetMouseButton(0)){
				Debug.Log("Mouse");
				float v = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
				float h = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
				v = Mathf.Clamp(v, -1, 1);
				h = Mathf.Clamp(h, -1, 1);
				transform.Rotate( v, h, 0);
			}
		}*/
	}

	/*void OnMouseDown() {
		isRotating = true;
		mouseReference = Input.mousePosition;
		Debug.Log("Mouse up");
	}

	void OnMouseUp() {
		isRotating = false;
		Debug.Log("Mouse down");
	}*/

	void OnMouseDrag() {
		float rotX = Input.GetAxis("Mouse X") * sensitivity * Mathf.Deg2Rad;
		float rotY = Input.GetAxis("Mouse Y") * sensitivity * Mathf.Deg2Rad;

		transform.Rotate(rotY, -rotX, 0, Space.World);

	}
}
