using UnityEngine;
using System.Collections;

public class SpawnKelps : MonoBehaviour {
	public GameObject kelpPrefab;
	float high1, high2;
	Vector3 spawnVector1, spawnVector2;
	CaptureTrash destroyCan;

	void Start()
	{
		high2 = -22;
		high1 = -3.9f;
		spawnVector1 = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y -3, gameObject.transform.position.z);
		spawnVector2 = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y -3, gameObject.transform.position.z);
		destroyCan = GetComponent<CaptureTrash> ();
	}

	public void SpawningKelp()
	{
	//	print ("FUNFAA");
		if(gameObject.tag == "Trash1"){
			Instantiate (kelpPrefab, spawnVector1, Quaternion.identity);
			destroyCan.canDestroy = true;
		}else if(gameObject.tag == "Trash2"){
			Instantiate (kelpPrefab, spawnVector2, Quaternion.identity);
			destroyCan.canDestroy = true;
		}
	
	}
}
