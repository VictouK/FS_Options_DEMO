using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class MoveToDefaultPosition : MonoBehaviour {

	public GameObject ParentObject;
	public GameObject [] OtherObjects;
	public Vector3[] StartingPositionOtherObjects;
	public VRTK_InteractableObject VRGrabObject;
	void Start () {
		if (VRGrabObject.enabled == true) {
			OtherObjects [0].transform.localPosition = StartingPositionOtherObjects [0];
			OtherObjects [1].transform.localPosition = StartingPositionOtherObjects [1];
			OtherObjects[0].GetComponent<VRTK_InteractableObject>().enabled = false;
			OtherObjects[1].GetComponent<VRTK_InteractableObject>().enabled = false;


			OtherObjects [0].GetComponentInChildren<DressRotation> ().RotateDresses = false;
			OtherObjects [1].GetComponentInChildren<DressRotation> ().RotateDresses = false;

			OtherObjects [0].transform.rotation = Quaternion.Euler (0f,90f, 0f);
			OtherObjects [1].transform.rotation = Quaternion.Euler (0f,90f, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (VRGrabObject.enabled == true) {
			OtherObjects [0].transform.localPosition = StartingPositionOtherObjects [0];
			OtherObjects [1].transform.localPosition = StartingPositionOtherObjects [1];
			OtherObjects[0].GetComponent<VRTK_InteractableObject>().enabled = false;
			OtherObjects[1].GetComponent<VRTK_InteractableObject>().enabled = false;

			OtherObjects [0].GetComponentInChildren<DressRotation> ().RotateDresses = false;
			OtherObjects [1].GetComponentInChildren<DressRotation> ().RotateDresses = false;

			OtherObjects [0].transform.rotation = Quaternion.Euler (0f,90f, 0f);
			OtherObjects [1].transform.rotation = Quaternion.Euler (0f,90f, 0f);
		}
	}
}
