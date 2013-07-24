using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {
	
	
	public GameObject initialPosition;
	public GameObject finalPosition;
	
	
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
			RoadControl.GenerateRoad( FindChild(this.name, "JointEnd") );
			Destroy( this.gameObject );
		}
	}
	
	
	private GameObject FindChild(string pRoot, string pName)
	{
	    Transform pTransform = GameObject.Find(pRoot).GetComponent<Transform>();
	    foreach (Transform trs in pTransform) {
	        if (trs.gameObject.name == pName)
	            return trs.gameObject;
	    }
	    return null;
	}
}
