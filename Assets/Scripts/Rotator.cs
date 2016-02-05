using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	private GameObject pickup;

	float x , y;
	// Update is called once per frame

	void Start()
	{
		x = transform.position.x; 
		y = transform.position.y;
	}

	void Update () {
		//Time.deltaTime makes rotation smooth

		transform.Rotate(new Vector3 (0,0,45)*Time.deltaTime);
		Children ();
		Debug.Log ("WHAAT");
		transform.Translate(new Vector3 (Random.Range(-14F, 14F)+x, Random.Range (-2f, 2f) + y, 0)*Time.deltaTime);
//		GameObject p = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
//		p.transform.Translate(new Vector3(5,5,0));


//		foreach(Transform childTransform in Pickups.transform) 
//		{
//			childTransform.gameObject.transform.Translate(new Vector3 (Random.Range(-14F, 14F)+x, Random.Range (-14f, 14f) + y, 0)*Time.deltaTime);
//		}
	}

	void Children () {
		Debug.Log ("TEH HELLL");

		bool goneHorizontal = false;
		Debug.Log ("please");
		Debug.Log (transform.childCount);

		for (int i=0; i < 12; i++)
		{
			Debug.Log ("god");
			pickup = transform.GetChild(0).gameObject;
			if (goneHorizontal == false)
			{
				pickup.transform.Translate(new Vector3 (0,Random.Range (-14f,14f)+y, 0));
				goneHorizontal = true;
				Debug.Log ("damm");
			} else {
				pickup.transform.Translate(new Vector3 (Random.Range (-14f, 14f)+ x, 0, 0));
				goneHorizontal = false;
				Debug.Log ("it");
			}
		}

		Debug.Log ("fuck");
	}
}