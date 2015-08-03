using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class AgentController : MonoBehaviour {


	private NavMeshAgent agent;
	private TargetController target;

	void Awake(){

		agent = GetComponent<NavMeshAgent> ();
		target = GameObject.FindObjectOfType<TargetController> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		agent.SetDestination (target.transform.position);

	}
}
