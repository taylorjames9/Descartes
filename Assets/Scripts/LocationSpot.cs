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
		//gameManager = GameObject.FindGameObjectWithTag("Manager");
		//if(gameManager.GetComponent<ViewManager>().DictionaryObjectsAndPoints.TryGetValue(

		//myCube_Proper = gameManager.GetComponent<ViewManager>().DictionaryObjectsAndPoints[transform.position];
	}
//
	void Update(){
		if (GetComponent<Renderer>().IsVisibleFrom(myViewCamera)) {

			Debug.Log("Visible");
			iAmVisible = true;
			//parentObject.GoToCorrectPosition();
			/////StartCoroutine (parentObject.GoToCorrectPosition());
			//parentObject.PlayAnimation();

		}
		else { 
			iAmVisible = false;
			Debug.Log("Not visible");
		}
//
	}

}
