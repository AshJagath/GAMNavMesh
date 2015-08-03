using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour {


	public LayerMask groundLayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//get teh down event of teh mouse clicking, rather than being true while teh button is down
		if (Input.GetMouseButton (0)) {

			// get the mouse position then draw a ray from teh camera
			Vector2 mouseScreenPosition = Input.mousePosition;
			Ray mouseRay = Camera.main.ScreenPointToRay(mouseScreenPosition);
				
			RaycastHit hit;

			if(Physics.Raycast(mouseRay, out hit, float.MaxValue, groundLayer.value)){

				Debug.Log("ground hit");

				transform.position = hit.point;

			}
		}


	}
}
