using UnityEngine;
using System.Collections;

public class flappyScript : MonoBehaviour {
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Fly ();
	
	}

	void Fly(){
		if (Input.GetKeyDown ("space")) {
			print ("fly");
			//transform.Translate(Vector3.up * Time.deltaTime*10, Space.World);
			rb.velocity= new Vector3(0,5,0);

		}
	}
}
