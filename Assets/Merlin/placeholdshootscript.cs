using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class placeholdshootscript : MonoBehaviour {

	// Use this for initialization
	public GameObject dynamite;


	void Start (){
		//Physics.IgnoreCollision(dynamite.GetComponent<BoxCollider>(), GetComponent<Collider>(), true);
		//Physics2D.IgnoreCollision (dynamite.GetComponent<BoxCollider2D>(), GetComponent<PolygonCollider2D>(), true);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			Shoot ();
		}
	}

	void Shoot () {
		Instantiate (dynamite, transform.position, transform.rotation);
	}


}
