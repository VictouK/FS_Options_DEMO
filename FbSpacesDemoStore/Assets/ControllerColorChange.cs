using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControllerColorChange : MonoBehaviour {

	private RaycastHit Rayhitinfo;
	public GameObject RayStarting,LeftHandRayStarting;
	Collider[] hitColliders;
	int i = 0;
	public GameObject MaggyLondong;
	public SpriteRenderer[] MaggyLondon;
	public Sprite[] MaggyLondonSprite;


	public GameObject Charley;
	public SpriteRenderer[] CharleySprites;
	public Sprite[] CharleySpriteChange;

	public GameObject Ruffle;
	public SpriteRenderer[] RuffleSprites;
	public Sprite[] RuffleSpriteChange;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (OVRInput.Get (OVRInput.Touch.SecondaryIndexTrigger) == false && OVRInput.Get (OVRInput.Touch.SecondaryThumbRest)) {

			hitColliders = Physics.OverlapSphere (RayStarting.transform.position, 0.01f);
			i = 0;
			while (i < hitColliders.Length)
			{
				FirstMaggyLondonDress ();
				SecondCharleysDress ();
				RuffleDress ();
				i++;
			}

			hitColliders = Physics.OverlapSphere (LeftHandRayStarting.transform.position, 0.01f);
			i = 0;
			while (i < hitColliders.Length)
			{
				FirstMaggyLondonDress ();
				SecondCharleysDress ();
				RuffleDress ();
				i++;
			}
		}
	}

	void FirstMaggyLondonDress(){
		if (hitColliders[i].tag == "FB_Spaces_MaggyLondon_Black") {
			MaggyLondong.GetComponent<Renderer> ().material.SetColor ("_Color", Color.black);
			MaggyLondon [0].sprite = MaggyLondonSprite [1];
		}

		if (hitColliders[i].tag == "FB_Spaces_MaggyLondon_Marron") {
			MaggyLondong.GetComponent<Renderer> ().material.SetColor ("_Color",new Color32(82,39,49,255));
			MaggyLondon [0].sprite = MaggyLondonSprite [0];
		}
	}


	void SecondCharleysDress(){
		
		if (hitColliders[i].tag == "FB_Spaces_CharlesHenryDressTurqoise") {
			Charley.GetComponent<Renderer> ().material.SetColor ("_Color",new Color32(26,200,185,255));
			CharleySprites [0].sprite = CharleySpriteChange [0];
		}
		if (hitColliders[i].tag == "FB_Spaces_CharlesHenryDressBlack") {
			Charley.GetComponent<Renderer> ().material.SetColor ("_Color", Color.black);
			CharleySprites [0].sprite = CharleySpriteChange [1];
		}

		if (hitColliders[i].tag == "FB_Spaces_CharlesHenryDressHotPink") {
			Charley.GetComponent<Renderer> ().material.SetColor ("_Color",new Color32(244,72,74,255));
			CharleySprites [0].sprite = CharleySpriteChange [2];
		}
		if (hitColliders[i].tag == "FB_Spaces_CharlesHenryDressMaroon") {
			Charley.GetComponent<Renderer> ().material.SetColor ("_Color",new Color32(82,39,49,255));
			CharleySprites [0].sprite = CharleySpriteChange [3];
		}

		if (hitColliders[i].tag == "FB_Spaces_CharlesHenryDressPink") {
			Charley.GetComponent<Renderer> ().material.SetColor ("_Color",new Color32(255,109,145,255));
			CharleySprites [0].sprite = CharleySpriteChange [4];
		}
		if (hitColliders[i].tag == "FB_Spaces_CharlesHenryDressBlue") {
			Charley.GetComponent<Renderer> ().material.SetColor ("_Color", new Color32(2,72,145,184));
			CharleySprites [0].sprite = CharleySpriteChange [5];
		}
	}

	void RuffleDress(){
		if (hitColliders[i].tag == "FB_Spaces_RuffleSleeve_Black") {
			Ruffle.GetComponent<Renderer> ().material.SetColor ("_Color",Color.black);
			RuffleSprites [0].sprite = RuffleSpriteChange [0];
		}
		if (hitColliders[i].tag == "FB_Spaces_RuffleSleeve_Blue") {
			Ruffle.GetComponent<Renderer> ().material.SetColor ("_Color", new Color32(2,72,145,184));
			RuffleSprites [0].sprite = RuffleSpriteChange [1];
		}
	}
}









