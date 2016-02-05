using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset; //position of player - position camera

	void Start () 
	{
		//if we do not especify which object is attached to transform it assumes self(object attached to the script)
		offset = transform.position - player.transform.position; 
	}

	//For follow cameras, Procedural animation and gathered last known states is best to use LateUpdate() 
	//LateUpdate() runs everyframe but it runs after everything has been updated

	void LateUpdate () 
	{
		transform.position = player.transform.position+ offset;
	}
}
