using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ExamineSystem : MonoBehaviour {

	private bool isExamining = false;
	private Vector3 examineObjectPosition;
	private GameObject examineObject;
	public float positionOffet;

	public GameObject examinePanel;

	public RigidbodyFirstPersonController playerController;
	void Update() {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit) && !isExamining)
		{
			if(hit.collider != null && hit.collider.GetComponent<InteractiveObject>() != null && Input.GetMouseButtonDown(0)){
				Debug.Log("Raycast hit");
				Debug.DrawRay(transform.position, transform.forward, Color.green);
				isExamining = true;
				examineObject = Instantiate(hit.collider.gameObject, Camera.main.transform.position + Camera.main.transform.forward * positionOffet, Quaternion.identity);
				examineObject.transform.eulerAngles = examineObject.GetComponent<InteractiveObject>().rotation;
				examineObject.transform.localScale = examineObject.GetComponent<InteractiveObject>().scale;
				examineObject.AddComponent<ExamineObject>();
				examineObject.layer = LayerMask.NameToLayer("Examine Object");
				Destroy(examineObject.GetComponent<InteractiveObject>());
				if(examineObject.GetComponent<GlowObjectCmd>() != null)
					Destroy(examineObject.GetComponent<GlowObjectCmd>());
				playerController.enabled = false;
				Time.timeScale = 0;
				examinePanel.SetActive(true);
			}
		}
		if(isExamining){
			if(Input.GetMouseButton(1)){
				Time.timeScale = 1;
				playerController.enabled = true;
				isExamining = false;
				Destroy(examineObject);
				examinePanel.SetActive(false);
				Debug.Log("Examination end");
			}
		}
	}

	// void OnDrawGizmosSelected() {
    //     Gizmos.color = Color.yellow;
    //     Gizmos.DrawSphere(Input.mousePosition, 1);
    // }
}
