using UnityEngine;
using System.Collections;

public class FireBallTestScript : MonoBehaviour {

	public float fireballSpeed = 30;
	//public float translation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(fireballSpeed * Time.deltaTime, 0, 0);
		if(transform.position.x >=20){
			transform.position = new Vector3(-20,0,0);
		}
		/*
		if (Input.GetKey("space")){
        	//when Space is pressed move Fireball a set distance
        	transform.Translate(fireballSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("b")){
        	transform.Translate(0,0,0);
        	transform.position = new Vector3(0, 0, 0);
        }*/
	
	}
}
