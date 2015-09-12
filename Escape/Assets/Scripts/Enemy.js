#pragma strict
var target : Transform; 

function Update() {
	transform.GetComponent(NavMeshAgent).destination = target.position;
	}