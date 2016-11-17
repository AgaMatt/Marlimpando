using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{


	public void Play ()
	{
		SceneManager.LoadScene ("InGame");
	}

	public void Credits ()
	{
		SceneManager.LoadScene ("Credits");
	}

	public void Return ()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void Exit ()
	{
		Application.Quit ();
	}
}
