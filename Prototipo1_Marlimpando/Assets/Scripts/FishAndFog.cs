using UnityEngine;
using System.Collections;

public class FishAndFog : MonoBehaviour {

	int activateFishes;
	public GameObject[] fishes = new GameObject[8];
	public GameObject lightDirectional, audioManager;
	public AudioClip winAudio;
	Color lightColor;
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
			RenderSettings.fogColor = new Color (0.153f, 0.109f, 0.109f);
		//	activateFishes++;
		}
		if(numTrash2 <= 140 && numTrash2 >= 135){
			fishes [4].SetActive (true);
		//	activateFishes++;
		}
		if(numTrash2 <= 125 && numTrash2 >= 120){
			fishes [5].SetActive (true);
			RenderSettings.fogColor = new Color (0.082f, 0.145f, 0.337f);
			RenderSettings.fogDensity = 0.002f;
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
		if(numTrash2 <=40){
			RenderSettings.fogDensity = 0.001f;
		}
		if(numTrash2 <=0){
			trashAmount.OpenTheBarrier ();
			lightColor = new Color (0.537f, 1, 0.521f);
			lightDirectional.GetComponent<Light> ().intensity = 0.005f;
			var ad = audioManager.GetComponent<AudioSource> ();
			ad.clip = winAudio;
			ad.Play ();
			ad.volume = 0.28f;
		}







	}
}
