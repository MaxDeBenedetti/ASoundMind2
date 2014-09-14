using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
		if(Input.anyKey || Input.GetMouseButton(0)){
			Application.LoadLevel(0);
		}
	}
}
