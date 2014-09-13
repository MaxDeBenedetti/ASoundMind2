using UnityEngine;
using System.Collections;

public class Thought : MonoBehaviour {


	public float speed = 2;


	private int flavor;
	
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
		flavor = Flavors.randColor();
		flavor = 1;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateMove();
	}

	void UpdateMove(){
		transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, Time.deltaTime * speed);
	}

}
