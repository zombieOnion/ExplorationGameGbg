using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

	public float moveSpeed = 30f;
	public float destroyTimer = 1f;
	private Object explosionOnce;
	private Vector3 explosionPos;
	private Object child1embers;
	private Object child2fireball;
	private Object child3lensflare;
	public Object child4smoketrail;
	public ParticleSystem psSmokeTrail;
	void Start () {
		//find the explosion FX in Resources folder
		explosionOnce = Resources.Load("fx_explosion_once");
		//find children
		child1embers = this.transform.Find("particle_embers").gameObject;
		child2fireball = this.transform.Find("particle_fireball").gameObject;
		child3lensflare = this.transform.Find("particle_lensflare").gameObject;
		child4smoketrail = this.transform.Find("particle_smoketrail").gameObject;
		//psSmokeTrail = child4smoketrail.GetComponent(typeof (ParticleSystem)) as ParticleSystem;
		//in child4smoketrail find script component SmokeTrailScript:
		psSmokeTrail = GetComponentInChildren<ParticleSystem>();

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,moveSpeed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision col){
		//döda sin egen collider så man ej studsar mot andra projektiler o ser konstig ut
		(gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = true;
		//(child4smoketrail.Getcomponent(typeof(ParticleSystem)) as ParticleSystem).isEmitting = false;
		//stoppa projektilen
		moveSpeed = 0f;
		//hämta en position som man kan sen spawna en "explosion" på
		explosionPos = transform.position;
		//skapa explosionen
		Instantiate(explosionOnce, explosionPos, transform.rotation);
		//destroy child objects 0, 1 and 2:
			Destroy(child1embers);
			Destroy(child2fireball);
			Destroy(child3lensflare);
		//make smoke emitter stop emitting, but don't kill the particles:
		//gameObject.BroadcastMessage(ParticleSystem.StopEmitting());
		//destroy self:
		psSmokeTrail.Stop();
		Destroy(gameObject, destroyTimer);
	}

}
