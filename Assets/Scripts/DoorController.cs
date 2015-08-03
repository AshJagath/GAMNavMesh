using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	//
	//public float open;
	public float openSpeed = 1;
	public bool open;
	private float openNormalTarget;
	[Range(0,1)]
	public float openNormal;
	[Range(0,0.8)]
	public float openthreshold;

	public Transform door;
	public float openDistance = 1.8f;
	public AnimationCurve openCurve;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (openNormal < openNormalTarget) {
				
			openNormal += openSpeed * Time.deltaTime;
			openNormal = Mathf.Clamp(openNormal,0, openNormalTarget);

		}else if(openNormal> openNormalTarget){

			openNormal -= openSpeed * Time.deltaTime;
			openNormal = Mathf.Clamp(openNormal,openNormalTarget, 1f);
		}
		
		-
		//obstacle.enable = openNormal > 0;

		door.localPosition = Vector3.Lerp 
			(Vector3.zero,
			 Vector3.forward * openDistance, openCurve.Evaluate(openNormal));

	}

	void OnTriggerEnter(Collider collider){
		Debug.Log ("close");
		openNormalTarget = 0;
		
		
	}

	void OnTriggerExit(Collider collider){
		Debug.Log ("open");
		openNormalTarget = 1;

	}

}
