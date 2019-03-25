using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {
	int movimento = 0;
	bool esquerda = false;
	bool direita = false;
	bool chao = false;

	float tempo;
	public static int vida = 3;
	public Text Textotempo,Tvidas;
	// Use this for initialization
	void Start () {
		tempo = Time.deltaTime;
		vida = 3;

	}
	
	// Update is called once per frame
	void Update () {
		TempCronometro ();
		Tvidas.text = "Vidas " +vida.ToString (); 

		Textotempo.text = "Distancia " +tempo.ToString (); 
		Mover ();
		if (movimento == 0){
			esquerda = true;
			direita = true;
			print (movimento);


		} else if (movimento == 1){
			direita = false;
			esquerda = true;
			print (movimento);

			}
		else if (movimento == -1){
			esquerda = false;
			direita = true;
			print (movimento);
		}
		if (vida <= 0) {
			SceneManager.LoadScene ("Perdeu", LoadSceneMode.Single);
		}
	}

	void Mover ()
	{
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (esquerda == true) {
				transform.Translate (-1.5f, 0.0f, 0.0f);
				movimento--;
			}
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			if (direita == true) {
				
				transform.Translate (1.5f, 0.0f, 0.0f);
				movimento++;
			}
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			if (chao == true) {
				chao = false;
				transform.Translate (0.0f, 3.5f, 0.0f);
			}
		}

	}
	void TempCronometro(){
		tempo += Time.deltaTime;

	} 
	void OnCollisionEnter(Collision c){
		if (c.gameObject.name == "Chao") {
			chao = true;
		} 
		else if (c.gameObject.name == "Ceu") {
			chao = false;
		}
	} 
}


