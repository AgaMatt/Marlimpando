using UnityEngine;
using System.Collections;

public class MovimentacaoAlga : MonoBehaviour
{
	public float vel;
	Vector3 ala;
	GameObject alga;

	void Start ()
	{
		ala = Input.mousePosition;
	}

	void Update ()
	{
		Movimentacao ();

	}

	void Movimentacao ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			GetComponent<Rigidbody>().velocity = Vector3.up * vel * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftControl)) {
			GetComponent<Rigidbody>().velocity = Vector3.down * vel * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.W)){
			GetComponent<Rigidbody> ().velocity = Vector3.forward * vel * Time.deltaTime;

		}
		if(Input.GetKey(KeyCode.S)){
			GetComponent<Rigidbody> ().velocity = Vector3.back * vel * Time.deltaTime;

		}
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody> ().velocity = Vector3.left * vel * Time.deltaTime;

		}
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody> ().velocity = Vector3.right * vel * Time.deltaTime;
		}
	}
}
