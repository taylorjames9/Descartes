using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cube_Proper : MonoBehaviour {



	private GameObject gameManager;
	private Dictionary<GameObject, Transform> myDict;
	private Transform myPosition;
	private Vector3 myHidingPosition;

	void Start(){
		myHidingPosition = transform.position;
		gameManager = GameObject.FindGameObjectWithTag("Manager");
		myDict = gameManager.GetComponent<ViewManager>().DictionaryObjectsAndPoints;
		if(myDict.TryGetValue(gameObject, out myPosition)){
			Debug.Log ("myPostion = "+myPosition.position);
		} else {
			Debug.Log ("Dictionary fail");
		}

	}

	void Update(){
		if(myPosition.gameObject.GetComponent<LocationSpot>().iAmVisible){
			StartCoroutine(GoToCorrectPosition());
		} else {
			StartCoroutine(GoToHidingPosition());
		}

	}

	public IEnumerator GoToCorrectPosition(){
		Debug.Log ("Should be going to the correct position");
		transform.position = Vector3.Lerp(transform.position, myPosition.position, Time.time/4);
		yield return new WaitForSeconds(0.0f);
	}
	public IEnumerator GoToHidingPosition(){
		Debug.Log ("Should be going to hiding");
		transform.position = Vector3.Lerp(transform.position, myHidingPosition, Time.time/4);
		yield return new WaitForSeconds(0.0f);
	}

}
