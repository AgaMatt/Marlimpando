using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrashCount : MonoBehaviour {

	//public GameObject trash1, trash2, trash3, trash4, trash5, trash6;
	int trashAmount;
	Text trashText;
	LevelBarrier levelCount;
	int remaining_lvl_1, remaining_lvl_2;


	void Start()
	{
		
		levelCount = FindObjectOfType<LevelBarrier> ();

		trashText = GetComponent<Text> ();

	}
	void Update ()
	{
		
		remaining_lvl_1 = levelCount.numberOfTrashes1;
		remaining_lvl_2 = levelCount.numberOfTrashes2;
		if (levelCount.opened){
			trashAmount = remaining_lvl_2;
		}else
			trashAmount = remaining_lvl_1;
/*		if(transform.childCount > 2)
		{
			Destroy (trash1);
		}
		if(transform.childCount >4)
		{
			Destroy (trash2);
		}
		if(transform.childCount >6)
		{
			Destroy (trash3);
		}
		if(transform.childCount >8)
		{
			Destroy (trash4);
		}
		if(transform.childCount >10)
		{
			Destroy (trash5);
		}
		if(transform.childCount >11)
		{
			Destroy (trash6);
		}

	*/
		//int rightAmount = trashAmount / 2;
		trashText.text = "Restando: " + trashAmount.ToString ();
	
	}
}
