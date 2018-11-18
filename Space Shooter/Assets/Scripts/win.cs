using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour {
	public Text text;
	private Scene scene;
	// Use this for initialization
	void Start () {
		scene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {
		if (scene.name == "Win") {
			text.text = ("Congratulations! You Win!!!!");
		}
	}
}
