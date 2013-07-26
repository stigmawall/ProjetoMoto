using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {
	
	
	Camera cam;
	
	
	// Use this for initialization
	void Start () {
		
		cam = Camera.main;
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance(cam.transform.position, FindChild( this.gameObject , "JointEnd" ).transform.position );
		//Debug.Log ( this.name + " - " + dist );
		
		if( dist < 40 ) {
			RoadControl.GenerateRoad( FindChild( RoadControl.last, "JointEnd") );
			Destroy( this.gameObject );
		}
		
		/*
		Vector3 original = this.gameObject.transform.position;
		Vector3 position = new Vector3( original.x, original.y, original.z-1 );
		this.gameObject.transform.position = position;
				
		if( original.z<=-120 ) 
		{
			RoadControl.GenerateRoad( FindChild( RoadControl.last, "JointEnd") );
			Destroy( this.gameObject );
		}*/
	}
	
	
	private GameObject FindChild(GameObject pRoot, string pName)
	{
	    Transform pTransform = pRoot.GetComponent<Transform>();
	    foreach (Transform trs in pTransform) {
	        if (trs.gameObject.name == pName)
	            return trs.gameObject;
	    }
	    return null;
	}
}
