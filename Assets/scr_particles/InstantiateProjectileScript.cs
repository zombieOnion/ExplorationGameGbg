using UnityEngine;
using System.Collections;

public class InstantiateProjectileScript : MonoBehaviour {
	Object varBullet;
	void Start () {
		varBullet = Resources.Load("fx_fireball");
		//Vector3 bulletPosition = new Vector3(0,2,0);
		Debug.Log("Bullet prefab loaded");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			Instantiate(varBullet, transform.position, transform.rotation);
		}
	}
}
