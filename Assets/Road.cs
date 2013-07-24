using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {
	
	
	private float inicialZ;
	
	
	// Use this for initialization
	void Start () {
		//inicialZ = this.gameObject.transform.position.z;
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 original = this.gameObject.transform.position;
		Vector3 position = new Vector3( original.x, original.y, original.z-1 );
		this.gameObject.transform.position = position;
		
		if( original.z<=-120 ) 
		{
			RoadControl.GenerateRoad();
			Destroy( this.gameObject );
		}
	}
}
