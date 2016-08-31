using UnityEngine;
using System.Collections;

public class CaptureTrash : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;
	Vector3 trashOffset;

	void OnTriggerEnter(Collider coll)
	{
		//print ("ALAA");
		if(coll.tag == "Player"){
			//print ("AAAAAA");
			transform.position = player.transform.position - offset - trashOffset;
			transform.SetParent (player.transform);
			trashOffset = trashOffset + transform.position;
		}
	}
}
