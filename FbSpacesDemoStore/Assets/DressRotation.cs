using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class DressRotation : MonoBehaviour {

	public VRTK_InteractableObject VRGrabObject;
	public bool RotateDresses = false;
	public GameObject ParentObject;
	public VRTK_ControllerEvents VRCONTROLLER;

	public GameObject ParticleEffect,clone;
	void Start (){
		clone = Instantiate (ParticleEffect);
		clone.SetActive (false);
	}
	

	void Update () {
		if (RotateDresses == true) {
			
			clone.SetActive (true);
			ParentObject.transform.rotation = Quaternion.Euler (0f,ParentObject.transform.eulerAngles.y, 0f);
			ParentObject.transform.Rotate (new Vector3(0f,1 * Time.deltaTime * 100f,0f));
		} else if(RotateDresses == false){
			clone.SetActive (false);
		}

		if (VRGrabObject.enabled == true) {
			//ParentObject.GetComponent<Renderer>().material.SetColor("_EmissionColor",Color.HSVToRGB(0.25f,0.25f,0.25f));
			ParentObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");

		} else if(VRGrabObject.enabled == false) {
			//ParentObject.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.clear);
			ParentObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

		}




	}


	void OnTriggerEnter(Collider coll){

		if (coll.gameObject.tag == "Untagged") {
			RotateDresses = false;

		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == true) {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == false) {
			RotateDresses = true;


		}	
	}


	void OnTriggerStay(Collider coll){

		if (coll.gameObject.tag == "Untagged") {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == true) {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == false) {
			RotateDresses = true;

		
		}	
	}


	void OnTriggerExit(Collider coll){

		if (coll.gameObject.tag == "Untagged") {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == true) {
			RotateDresses = false;
		}

		if (coll.gameObject.tag == "Table" && VRGrabObject.enabled == false) {
			RotateDresses = true;
		}	
	}
}
