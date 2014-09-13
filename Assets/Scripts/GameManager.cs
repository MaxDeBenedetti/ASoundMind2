using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Thought[] thoughts;
	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		SpawnThought();
	}

	void SpawnThought(){
		Vector3 spawnplace = spawnPoints[(int)UnityEngine.Random.Range(0,spawnPoints.Length)].position;
		Thought thought = thoughts[(int)UnityEngine.Random.value*thoughts.Length];
		GameObject.Instantiate(thought,spawnplace,Quaternion.identity);
	}
}
