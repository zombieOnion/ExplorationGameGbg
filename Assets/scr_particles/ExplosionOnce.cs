﻿using UnityEngine;
using System.Collections;



public class ExplosionOnce : MonoBehaviour {

	public float destroyTimer;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, destroyTimer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
