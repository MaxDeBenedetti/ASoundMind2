using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Thought[] thoughts;
	public float minWait, maxWait, impatient;
	public bool gameplaying = true;
	private float wait;
	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
		wait = maxWait;
		StartCoroutine("distract");
	}
	
	// Update is called once per frame
	void Update () {


	}

	IEnumerator distract(){
		while(gameplaying){
			if(minWait < wait){
				wait -= impatient;
			}
			SpawnThought();
			yield return new WaitForSeconds(wait);
		}
	}

	void SpawnThought(){
		Vector3 spawnplace = spawnPoints[(int)UnityEngine.Random.Range(0,spawnPoints.Length)].position;
		Thought thought = thoughts[(int)UnityEngine.Random.Range(0,thoughts.Length)];
		GameObject.Instantiate(thought,spawnplace,Quaternion.identity);
	}
}
