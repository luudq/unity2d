using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public float chinaBegin;
	public float chinaDelay;
	public GameObject china;
	// Use this for initialization
	void Start () {
		//random
		chinaBegin = Random.Range (3f,5f);
		chinaDelay = Random.Range (3f,5f);
		InvokeRepeating ("SpawnChina", chinaBegin, chinaDelay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnChina(){
		Instantiate (china, transform.position, transform.rotation);
	}
}
