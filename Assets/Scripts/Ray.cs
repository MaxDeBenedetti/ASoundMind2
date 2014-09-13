using UnityEngine;
using System.Collections;

public class Ray : MonoBehaviour {

	public Aura aura;

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
		this.flavor = aura.Flavor;
		flavor = 1;
		rigidbody.velocity = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("thing");
		if(other.gameObject.tag.Equals(Tags.thought)){
			Thought tht = other.gameObject.GetComponent<Thought>();
			if(flavor == tht.Flavor){
				GameObject.Destroy(other.gameObject);
			}
		}
	}
}
