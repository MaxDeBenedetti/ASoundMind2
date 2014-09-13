using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
[RequireComponent(typeof (SpriteRenderer))]
public class Beam : MonoBehaviour {

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
		SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
		switch (flavor) {
		case 1: spr.color = Color.blue;
			break;
		case 2: spr.color = Color.green;
			break;
		case 3: spr.color = Color.red;
			break;
		default: spr.color = Color.grey;
						break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag.Equals(Tags.thought)){
			Thought tht = other.gameObject.GetComponent<Thought>();
			if(flavor == tht.Flavor){
				GameObject.Destroy(other.gameObject);
			}
		}
		if(other.gameObject.tag.Equals(Tags.boundry)){
			GameObject.Destroy(this.gameObject);
		}
	}
}
