using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamiteGoBoomBoomPlaceholder : MonoBehaviour {
	float spawnTimer;
	float destroyTimer;
	bool canExplode;

	public GameObject _spritemask;

	void Awake(){
		spawnTimer = 3f;
		destroyTimer = 2f;
		canExplode = true;
	
	//Destroy (gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnTimer -= Time.deltaTime;	
		if(spawnTimer <= 0) 
		{
			destroyTimer -= Time.deltaTime;

			if (canExplode) { DestroyLevelChunk ();	}

			if (destroyTimer <= 0) 
			{
				Destroy (gameObject);
				Debug.Log ("why not work");
			}
		
		}
	
	}

	void DestroyLevelChunk() 
	{
		Instantiate (_spritemask, transform.position, transform.rotation);
		canExplode = false;
	}

}

