using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerExplosion;
	private GameController gameController;
	public int scoreValue;
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if(gameControllerObject != null){
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null) {
			Debug.Log ("CANNOT FIND THE GAME CONTROLLER SCRIPT");
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary") {
			return;
		}
		if (other.tag == "Sun") {
			return;
		}
		Instantiate (explosion, transform.position, transform.rotation);
		if( other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameController.Gameover ();
		}
		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);

	}
}
