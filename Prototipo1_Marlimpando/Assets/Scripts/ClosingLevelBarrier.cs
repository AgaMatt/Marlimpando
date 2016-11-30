using UnityEngine;
using System.Collections;

public class ClosingLevelBarrier : MonoBehaviour {

	LevelBarrier levelBarrier;
	public Color level2_Color;
	// Use this for initialization
	void Start () {
		levelBarrier = FindObjectOfType<LevelBarrier> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col)
	{
		//print ("TRIGEro");
		if(col.tag == "Player"){
			levelBarrier.CloseTheBarrier ();
			RenderSettings.fogColor = level2_Color;
			Destroy (gameObject);
		}
	}
}
