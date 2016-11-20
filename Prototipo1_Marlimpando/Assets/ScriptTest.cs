using UnityEngine;
using System.Collections;

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll)
	{
		print ("MEU OVO");
		if(coll.gameObject.tag == "Kelp"){
			print ("TA ME TROLANDO FDP?");
		}
	}
}
