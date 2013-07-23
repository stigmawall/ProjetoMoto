using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
		//roads = GameObject.FindGameObjectsWithTag("Road");
	}
	
	// Update is called once per frame
	void Update () {
		
		// Update camera
		Vector3 original = this.gameObject.transform.position;
		Vector3 position = new Vector3( GameObject.Find("Player").gameObject.transform.position.x, original.y, original.z );
		this.gameObject.transform.position = position;
	}
	
	
}
