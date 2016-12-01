using UnityEngine;
using System.Collections;

public class SmokeTrailScript : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		//ParticleSystem ps = GetComponent<ParticleSystem>();
	}

	public void StopEmitting() {
		//ps.Stop(includeChildren, ParticleSystemStopBehavior.StopEmitting);
		ParticleSystem ps = GetComponent<ParticleSystem>();
		ps.Stop();
	}
}
