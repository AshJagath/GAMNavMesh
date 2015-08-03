using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	public Color[] colours = new Color[]{

		Color.red,
		Color.blue,
		Color.green

	};

	public float cycleDelay = 1f;

	IEnumerator CycleColour(){
			
		while (true) {
						renderer.material.color = colours [0];
						yield return new WaitForSeconds (cycleDelay);
						renderer.material.color = colours [1];
						yield return new WaitForSeconds (cycleDelay);
						renderer.material.color = colours [2];
				}
		}


	// Use this for initialization
	void Start () {

		StartCoroutine (CycleColour ());


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
