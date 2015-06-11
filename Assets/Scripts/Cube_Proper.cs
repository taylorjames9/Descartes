using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cube_Proper : MonoBehaviour {
	private GameObject gameManager;
	private Dictionary<GameObject, Transform> myDict;
	private Transform myPosition;
	private Vector3 myHidingPosition;
	private bool calledVisible;

	void Start(){
		myHidingPosition = transform.position;
		gameManager = GameObject.FindGameObjectWithTag("Manager");
		myDict = gameManager.GetComponent<ViewManager>().DictionaryObjectsAndPoints;
		if(myDict.TryGetValue(gameObject, out myPosition)){
			myPosition = myPosition;
			//Debug.Log ("myPostion = "+myPosition.position);
		} else {
			myPosition = null;
			//Debug.Log ("Dictionary fail");
		}

	}

	void Update(){
		if(myPosition != null){
		if(myPosition.GetComponent<LocationSpot>().iAmVisible){
			//Debug.Log ("INSIDE");
			StartCoroutine(GoToCorrectPosition());
		} else if(myPosition.gameObject.GetComponent<LocationSpot>().iAmVisible == false) {
			StartCoroutine(GoToHidingPosition());
		}
		}

	}

	public IEnumerator GoToCorrectPosition(){
		//Debug.Log ("Should be going to the correct position");
		transform.position = Vector3.Lerp(transform.position, myPosition.position, Time.deltaTime *5);
		yield return new WaitForSeconds(0.0f);
		//calledVisible = true;
	}
	public IEnumerator GoToHidingPosition(){
		//Debug.Log ("Should be going to hiding");
		transform.position = Vector3.Lerp(transform.position, myHidingPosition, Time.deltaTime);
		yield return new WaitForSeconds(0.0f);
		//calledVisible = false;
	}

}
