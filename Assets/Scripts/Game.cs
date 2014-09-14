using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.R)){
			Application.LoadLevel("Main");
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
