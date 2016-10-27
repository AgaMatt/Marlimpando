using UnityEngine;
using System.Collections;

public class UnderWaterIdle : MonoBehaviour {

	Vector3 randomRot;
	
	// Update is called once per frame
	void Update () {
		randomRot = new Vector3(Random.Range (0, 6), Random.Range (0, 6), Random.Range(0, 6));
		
		transform.Rotate (randomRot);
	}
}
