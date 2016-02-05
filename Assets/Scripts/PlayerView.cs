using UnityEngine;
using System.Collections;

public class PlayerView : MonoBehaviour {
	
	//Update() called before rendering a frame
	//FixedUpdate() just before perfoming any physics
	public float speed;
	private Rigidbody2D rb2d; 
	private int countPickup;
	
	void Start() 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		countPickup = 0;

	}
	
	void FixedUpdate() 
	{
		//keys Horizontal are default set on Input manager
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		
		rb2d.AddForce(movement*speed);
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
			countPickup++;
		}

	}
	
	
}
