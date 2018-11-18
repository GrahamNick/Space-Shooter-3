using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SunWin : MonoBehaviour {
	public Text gameOver;
	[HideInInspector]
	public GameController gameController;
	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if(gameControllerObject != null){
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null) {
			Debug.Log ("CANNOT FIND THE GAME CONTROLLER SCRIPT");
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			gameOver.text = "You Win";
			gameController.winCondition ();
		}
	}
}
