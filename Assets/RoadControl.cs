using UnityEngine;
using System.Collections;

static public class RoadControl {
	
	static public GameObject last = GameObject.Find ("RoadLast");
	
	static public void GenerateRoad( GameObject point ) 
	{
		int random = Random.Range(1,1);
		Object prefab = Resources.Load("Road" + random ); 
		last = (GameObject)GameObject.Instantiate( prefab, point.transform.position, point.transform.rotation ); //Quaternion.identity );
	}
}
