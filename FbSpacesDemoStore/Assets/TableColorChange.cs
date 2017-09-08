using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableColorChange : MonoBehaviour {

	public GameObject [] ALLDressColorsObjects;
	public GameObject[] ALLDressColors;


	void Start(){
		AllDressColorsFalse ();
	}
	void OnTriggerStay(Collider coll){
		
		if (coll.gameObject.tag == "FB_Spaces_MaggyLondon") {
			AllDressColorsFalse ();
			ALLDressColors [0].SetActive (true);
		}

		if (coll.gameObject.tag == "FB_Spaces_CharlesHenryDress") {
			AllDressColorsFalse ();
			ALLDressColors [1].SetActive (true);
		}

		if (coll.gameObject.tag == "FB_Spaces_RuffleSleeve") {
			AllDressColorsFalse ();
			ALLDressColors [2].SetActive (true);


		}	
	}


	void Update(){
		if(ALLDressColorsObjects[0].GetComponent<DressRotation> ().RotateDresses == false && 
			ALLDressColorsObjects[1].GetComponent<DressRotation> ().RotateDresses == false && 
			ALLDressColorsObjects[2].GetComponent<DressRotation> ().RotateDresses == false ){
			AllDressColorsFalse ();
		}
	}

	void AllDressColorsFalse(){
		foreach (GameObject obj in ALLDressColors) {
			obj.SetActive (false);
		}
	}

}




