using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ViewManager : MonoBehaviour {

	public GameObject myCubePrefab;
	public Camera myCameraPerspective; 
	public GameObject locationDots;
	private Dictionary<GameObject, Transform> dictOfObjectsAndPoints = new Dictionary<GameObject, Transform>();
	public Dictionary<GameObject, Transform> DictionaryObjectsAndPoints {
		get{
			return dictOfObjectsAndPoints;
		}
		set{
			dictOfObjectsAndPoints = value;
		}
	}


	void OnEnable(){
		for(int i=0;i<50;i++){
			Vector3 myVector3 = new Vector3(
				Random.Range (-40,40), 
				Random.Range (-10,10),
				Random.Range (-40, 40));
			GameObject mylocation = (GameObject)Instantiate(locationDots, new Vector3(
				myVector3.x, 
				myVector3.y,
				myVector3.z), Quaternion.identity);
			GameObject myCubeObject = (GameObject)Instantiate (myCubePrefab, new Vector3(
				myVector3.x, 
				myVector3.y -20,
				myVector3.z), Quaternion.identity);
			dictOfObjectsAndPoints.Add (myCubeObject, mylocation.transform);
		}
	}

	void Update(){

	}

}
