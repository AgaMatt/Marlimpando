using UnityEngine;
using System.Collections;

public class Helpers : MonoBehaviour {

	int activateHelpers;
	public GameObject[] helpers;
	void Start()
	{
		//print (theHelper);
		activateHelpers = 0;
	}

	void OnTriggerEnter(Collider col)
	{
		//print ("ASDAS");
		if(col.tag =="Player"){
			//print ("FHUEFHRY");
			helpers [activateHelpers].SetActive (true);
			Destroy (gameObject);
			activateHelpers++;


		}	
	}
}
