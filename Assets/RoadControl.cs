using UnityEngine;
using System.Collections;

static public class RoadControl {
	
	static public void GenerateRoad() 
	{
		int random = Random.Range(1,4);
		Object prefab = Resources.Load("Road" + random ); 
		GameObject.Instantiate( prefab, new Vector3(0,0,238), Quaternion.identity );
		
		Debug.Log ( random );
	}
}
