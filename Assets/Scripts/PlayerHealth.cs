using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {


	public int health;
	public static int staticHealth;
	public GameManager gm;
	public TextMesh text;
	// Use this for initialization
	void Start () {
		staticHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		health = staticHealth;
		text.text = "Health: " + health;
		if(health <=0){
			Lose();
		}
	}

	void Lose(){
		gm.gameplaying = false;
		Aura aura = this.gameObject.GetComponent<Aura>();
		aura.enabled = false;
	}

	void OnTriggerStay(Collider col){
		if(col.gameObject.tag.Equals(Tags.thought)){
			if(health>0){
				health -=1;
			}
		}
	}
}
