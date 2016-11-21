using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyLevelBarrier : MonoBehaviour {
	GameObject[] level1Trash;
	// Use this for initialization
	void Start () {
		level1Trash = GameObject.FindGameObjectsWithTag ("Level1");
		print (level1Trash);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
