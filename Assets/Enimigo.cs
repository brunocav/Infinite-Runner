using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimigo : MonoBehaviour {
	int vel = 5;
	// Use this for initialization
	void Start () {
		Destroy (gameObject,6.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0.0f, 0.0f,- 0.2f);
	//	*vel * Time.deltaTime; 
	}
	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "Player"){
			Destroy (gameObject);
			Player.vida--;
		}
	} 
}
