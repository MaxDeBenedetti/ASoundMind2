using UnityEngine;
using System.Collections;

public class Thought : MonoBehaviour {

	public GameObject target;
	public float speed;

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
	}
	
	// Update is called once per frame
	void Update () {
		UpdateMove();
	}

	void UpdateMove(){
		transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * this.speed);

	}

}
