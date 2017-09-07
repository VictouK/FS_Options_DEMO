using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class DressRotation : MonoBehaviour {

	public VRTK_InteractableObject VRGrabObject;
	private bool RotateDresses = false;
	public GameObject ParentObject;
	public VRTK_ControllerEvents VRCONTROLLER;


	void Start (){
		
	}
	

	void Update () {
		if (RotateDresses == true) {
			ParentObject.transform.Rotate (Vector3.up * Time.deltaTime * 100f);
		} else if(RotateDresses == false){
			
		}



	}


	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == true) {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == false) {
			RotateDresses = true;
		}	
	}


	void OnTriggerStay(Collider coll){
		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == true) {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == false) {
			RotateDresses = true;
		}	
	}


	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == true) {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == false) {
			RotateDresses = true;
		}	
	}
}
