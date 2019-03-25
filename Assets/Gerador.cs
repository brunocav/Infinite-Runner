using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour {
	public GameObject Enimigo,P1,P2;
	public float intervalo ;

	void Start () {
		StartCoroutine (GeradorE (intervalo));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator GeradorE(float t){
		int x = Random.Range (1, 3);
		yield return new WaitForSeconds (2f);
		if (x == 1) {
			Instantiate (Enimigo, transform.position, Quaternion.identity);
		} else if (x == 2) {
			Instantiate (Enimigo, P1.transform.position, Quaternion.identity);
					
		}else if (x == 3) {
			Instantiate (Enimigo, P2.transform.position, Quaternion.identity);
		}

		StartCoroutine (GeradorE (intervalo));
	}
}
