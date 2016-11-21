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
			/*if (gameObject.transform.localScale.x > 13)
				isGrowing = false;*/
	}


	}

	void OnTriggerEnter(Collider cola)
	{
		if(cola.tag =="Barrier"){

			isGrowing = false;
		}
	}


}
