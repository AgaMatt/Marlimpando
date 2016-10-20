using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class RestartAndClose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.R))
		{
			SceneManager.LoadScene ("InGame");
		}
		if(Input.GetKey (KeyCode.P))
		{
			Application.Quit ();
		}
	}
}
