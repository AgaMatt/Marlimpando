using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrashCount : MonoBehaviour {

	//public GameObject trash1, trash2, trash3, trash4, trash5, trash6;
	public int trashAmount;
	Text trashText;


	void Start()
	{
		trashText = FindObjectOfType<Text> ();
		trashAmount = 0;
	}
	void Update ()
	{
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
		int rightAmount = trashAmount / 2;
		trashText.text = ": " + rightAmount.ToString ();
	
	}
}
