using UnityEngine;
using System.Collections;

public class GrowKelp : MonoBehaviour {
	Vector3 growing;
	bool isGrowing;
	public float growSpeed;
	// Use this for initialization
	void Start () {
		isGrowing = true;
		growing = new Vector3 (growSpeed, growSpeed, growSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		if(isGrowing){
			gameObject.transform.localScale += growing;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		print ("penetrou");
		if(coll.tag == "Barrier"){
			print ("isso memo");
			isGrowing = false;
		}
	}
}
