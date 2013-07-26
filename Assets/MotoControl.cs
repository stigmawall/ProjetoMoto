using UnityEngine;
using System.Collections;

public class MotoControl : MonoBehaviour {
	
	
	public float MoveSpeed = 70;
	public float RotateSpeed = 20;
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// Amount to Move
	    float MoveForward = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
	    float MoveRotate = Input.GetAxis("Horizontal") * RotateSpeed * Time.deltaTime;
	 	
	    // Move the player
	    transform.Translate(Vector3.forward * MoveForward);
		
		//if( ( transform.rotation.y <= 0.25 || MoveRotate<0 ) && ( transform.rotation.y >= -0.25 || MoveRotate>0 ) )
			transform.Rotate(Vector3.up * MoveRotate);
	}
}
