using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

	public float moveSpeed = 30f;
	public float destroyTimer = 1f;
	private Object explosionOnce;
	private Vector3 explosionPos;
	private Object child1;
	private Object child2;
	private Object child3;
	void Start () {
		explosionOnce = Resources.Load("fx_explosion_once");
		//Find the components needed in child objects for the "once" explosions
		child1 = this.transform.Find("particle_embers").gameObject;
		child2 = this.transform.Find("particle_fireball").gameObject;
		child3 = this.transform.Find("particle_lensflare").gameObject;
		//fx_sparks_once = this.transform.Find("embers_once").gameObject;

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
	}

	void OnCollisionEnter(Collision col){
		//döda sin egen collider så man ej studsar mot andra projektiler o ser konstig ut
		(gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = true;
		//stoppa projektilen
		moveSpeed = 0f;
		//hämta en position som man kan sen spawna en "explosion" på
		explosionPos = transform.position;
		//skapa explosionen
		Instantiate(explosionOnce, explosionPos, transform.rotation);
		//destroy child objects 0, 1 and 2:
		Destroy(child1);
		Destroy(child2);
		Destroy(child3);
		//destroy self:
		Destroy(gameObject, destroyTimer);
	}
}
