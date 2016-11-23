using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

	public float flickerSpeed = 0.07f;
	public Light lt;

	// Use this for initialization
	void Start () {
	    lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		lt.color -= Color.white / 2.0F * Time.deltaTime;
	}
}
