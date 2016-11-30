using UnityEngine;
using System.Collections;

public class FishAndFog : MonoBehaviour {

	int activateFishes;
	public GameObject[] fishes = new GameObject[8];
	LevelBarrier trashAmount;
	float numTrash2;
	void Start()
	{
		trashAmount = FindObjectOfType<LevelBarrier> ();

		//print (theHelper);
	//	activateFishes = 0;
	}

	void Update()
	{
		numTrash2 = trashAmount.numberOfTrashes2;
		ActivateFish ();
	}


	void ActivateFish()
	{
		//print ("MEEEEEE");
		if(numTrash2 == 200 && numTrash2 >= 196){
			print ("VAI ME FUDEE");
			fishes [0].SetActive (true);
		//	activateFishes++;
		}
		if(numTrash2 <= 185 && numTrash2 >= 180){
			fishes [1].SetActive (true);
			//activateFishes++;
		}
		if(numTrash2 <= 170 && numTrash2 >= 166){
			fishes [2].SetActive (true);
			//activateFishes++;
		}
		if(numTrash2 <= 155 && numTrash2 >= 150){
			fishes [3].SetActive (true);
		//	activateFishes++;
		}
		if(numTrash2 <= 140 && numTrash2 >= 135){
			fishes [4].SetActive (true);
		//	activateFishes++;
		}
		if(numTrash2 <= 125 && numTrash2 >= 120){
			fishes [5].SetActive (true);
		//	activateFishes++;
		}
		if(numTrash2 <= 120 && numTrash2 >= 115){
			fishes [6].SetActive (true);
		//	activateFishes++;
		}
		if(numTrash2 <= 105 && numTrash2 >= 100){
			fishes [7].SetActive (true);
		//	activateFishes++;
		}







	}
}
