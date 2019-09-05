using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class BtnTour : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vb_Object;
	public VideoPlayer tourismResult;

	// Use this for initialization
	void Start () {
		vb_Object = GameObject.Find ("BtnTourism");
		vb_Object.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		tourismResult = GameObject.Find ("TourismResult").GetComponent<VideoPlayer> ();
	}
	
	public void OnButtonPressed(VirtualButtonBehaviour vb){
		tourismResult.Play ();
		Debug.Log ("Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		tourismResult.Pause ();
		Debug.Log ("Released");
	}
}
