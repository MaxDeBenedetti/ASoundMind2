using UnityEngine;
using System.Collections;

public class Aura : MonoBehaviour {

	public Beam beam;
	public SpriteRenderer flavorIndicator;
	public float beamSpeed = 1;
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
		flavor = Flavors.blue;
	}
	
	// Update is called once per frame
	void Update () {
		//changes flavor
		if(Input.GetKeyDown(KeyCode.A)){
			Flavor = Flavors.red;
			flavorIndicator.color = Color.red;
		}
		if(Input.GetKeyDown(KeyCode.W)){
			Flavor = Flavors.blue;
			flavorIndicator.color = Color.blue;
		}
		if(Input.GetKeyDown(KeyCode.D)){
			Flavor = Flavors.green;
			flavorIndicator.color = Color.green;
		}

		//shoots in a specified direction
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			Beam b = (Beam)GameObject.Instantiate(beam,Vector3.zero,Quaternion.Euler(0,0,90));
			b.Flavor = flavor;
			Rigidbody rig = b.gameObject.GetComponent<Rigidbody>();
			rig.velocity = Vector3.up * beamSpeed;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			Beam b = (Beam)GameObject.Instantiate(beam,Vector3.zero,Quaternion.Euler(0,0,180));
			b.Flavor = flavor;
			Rigidbody rig = b.gameObject.GetComponent<Rigidbody>();
			rig.velocity = Vector3.left * beamSpeed;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			Beam b = (Beam)GameObject.Instantiate(beam,Vector3.zero,Quaternion.Euler(0,0,0));
			b.Flavor = flavor;
			Rigidbody rig = b.gameObject.GetComponent<Rigidbody>();
			rig.velocity = Vector3.right * beamSpeed;
		}


	}
}
