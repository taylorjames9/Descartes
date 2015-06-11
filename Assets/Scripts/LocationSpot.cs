using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LocationSpot : MonoBehaviour {
	
	private Camera myViewCamera;
	private GameObject myCube_Proper;
	private GameObject gameManager;
	private Dictionary<GameObject, Transform> myDict;
	public bool iAmVisible;


	void Start(){
		myViewCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	}
	void Update(){
		if (GetComponent<Renderer>().IsVisibleFrom(myViewCamera)) {

			//Debug.Log("Visible");
			iAmVisible = true;
		}
		else { 
			//Debug.Log("NOT VISIBLE");
			iAmVisible = false;

		}
	}
}
