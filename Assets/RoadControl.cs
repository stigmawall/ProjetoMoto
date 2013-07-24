using UnityEngine;
using System.Collections;

static public class RoadControl {
	
	static public void GenerateRoad( GameObject point ) 
	{
		int random = Random.Range(1,3);
		Object prefab = Resources.Load("Road" + random ); 
		GameObject.Instantiate( prefab, point.transform.position, point.transform.rotation ); //Quaternion.identity );
	}
}
