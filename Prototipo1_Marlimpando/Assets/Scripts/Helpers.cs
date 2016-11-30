using UnityEngine;
using System.Collections;

public class Helpers : MonoBehaviour {

	public int activateHelpers;
	public GameObject[] helpers;
	void Start()
	{
		//print (theHelper);
	

	}

	void OnTriggerEnter(Collider col)
	{
		//print ("ASDAS");
		if(col.tag =="Player"){
			{
				helpers [activateHelpers].SetActive (true);

				Destroy (gameObject);
			}


		}	
	}
}
