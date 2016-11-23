using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelBarrier : MonoBehaviour {
	public GameObject[] level1Trash;
	public int numberOfTrashes1, numberOfTrashes2;
	GameObject barrier;
	bool opened;
	// Use this for initialization
	void Start () {
		
		barrier = GameObject.FindGameObjectWithTag ("LevelBarrier");
		level1Trash = GameObject.FindGameObjectsWithTag ("Trash1");
		foreach(GameObject g in level1Trash){
			numberOfTrashes1++;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (numberOfTrashes1);
		if (numberOfTrashes1 == 27) {
			print ("OK");

			if (opened == false) {
				OpenTheBarrier ();
				opened = true;
				}
			}

		}
	public void OpenTheBarrier()
	{
		barrier.transform.localScale = new Vector3 (30, 21.4f, 30);
	}
		
	public void CloseTheBarrier()
	{
		barrier.transform.localScale = new Vector3 (30, 70, 30);
	}
}
	

