using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	public float distance = 25;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 player = GameObject.Find("Player").gameObject.transform.position;
		
		// Update camera
		Vector3 original = this.gameObject.transform.position;
		Vector3 position = new Vector3( player.x, original.y, player.z-distance );
		this.gameObject.transform.position = position;
	}
	
	
}
