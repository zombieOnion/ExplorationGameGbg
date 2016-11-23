using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

	public float moveSpeed = 30f;
	public float destroyTimer = 1f;
	private Object explosionOnce;
	private Vector3 explosionPos;
	void Start () {
		explosionOnce = Resources.Load("fx_explosion_once");
		//Find the components needed in child objects for the "once" explosions
		//fx_explosion_once = this.transform.Find("explosion_once").gameObject;
		//fx_sparks_once = this.transform.Find("embers_once").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
	}

	void OnCollisionEnter(Collision col){
		explosionPos = transform.position;
		Instantiate(explosionOnce, explosionPos, transform.rotation);
		Destroy(gameObject);
	}
}
