using UnityEngine;
using System.Collections;

public class CaptureTrash : MonoBehaviour {
	/*public GameObject player;
	public Vector3 offset;
	Vector3 trashOffset;*/
	TrashCount trashCount;
	SpawnKelps spawnKelp;
	public bool canDestroy;
	void Start()
	{
		spawnKelp = GetComponent<SpawnKelps> ();
		trashCount = FindObjectOfType<TrashCount> ();
		//print (trashCount.name);
	}

	void OnTriggerEnter(Collider coll)
	{
		/*print ("ALAA");
		if(coll.tag == "Player"){
			print ("AAAAAA");
			transform.position = player.transform.position - offset - trashOffset;
			transform.SetParent (player.transform);
			trashOffset = trashOffset + transform.position;
		}*/
		if(coll.tag == "Player"){
			//print ("por que??");
			spawnKelp.SpawningKelp ();
			trashCount.trashAmount ++;

			if (canDestroy) {
				Destroy (gameObject);
			}
				//print (trashCount.trashAmount);
		}

	}
}
