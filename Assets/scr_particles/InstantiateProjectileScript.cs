using UnityEngine;
using System.Collections;

public class InstantiateProjectileScript : MonoBehaviour {
	public GameObject particle;
	Object varBullet;
	void Start () {
		varBullet = Resources.Load("fx_fireball");
		//Vector3 bulletPosition = new Vector3(0,2,0);
		Debug.Log("Bullet prefab loaded");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 1000)){
				Debug.DrawLine(ray.origin, hit.point);
				transform.LookAt(hit.point, Vector3.up);
				Instantiate(varBullet, transform.position, transform.rotation);
			}
		}
	}
}
