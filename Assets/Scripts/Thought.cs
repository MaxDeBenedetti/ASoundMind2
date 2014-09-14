using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class Thought : MonoBehaviour {


	public float speed = 2;


	public int flavor;
	
	public int Flavor{
		get{
			return flavor;
		}
		set{
			flavor = value;
		}
		
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		UpdateMove();
		if(transform.position.Equals(Vector3.zero)){
			PlayerHealth.staticHealth -= 1;
		}
	}

	void UpdateMove(){
		transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, Time.deltaTime * speed);
	}

}
