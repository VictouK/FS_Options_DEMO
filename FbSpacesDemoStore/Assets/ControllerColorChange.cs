using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerColorChange : MonoBehaviour {

	private RaycastHit Rayhitinfo;
	public GameObject RayStarting;
	public GameObject[] ONDresses;
	void Start () {
		AllDressFalse ();
	}
	
	// Update is called once per frame
	void Update () {

		if (OVRInput.Get (OVRInput.Touch.SecondaryIndexTrigger) == false && OVRInput.Get (OVRInput.Touch.SecondaryThumbRest)) {
			if(Physics.Raycast(RayStarting.transform.position,transform.forward,out Rayhitinfo,0.01f)){
				if (Rayhitinfo.collider.tag == "FB_Spaces_CharlesHenryDress") {
					AllDressFalse (); ONDresses [0].SetActive (true);
				}else if(Rayhitinfo.collider.tag == "FB_Spaces_MaggyLondon"){
					AllDressFalse (); ONDresses [1].SetActive (true);
				}else if(Rayhitinfo.collider.tag == "FB_Spaces_RuffleSleeve"){
					AllDressFalse (); ONDresses [2].SetActive (true);
				}
			}
		}
	}

	private void AllDressFalse(){
		foreach (GameObject objs in ONDresses) {
			objs.SetActive (false);
		}
	}
}

