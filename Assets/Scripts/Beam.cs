using UnityEngine;
using System.Collections;

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
