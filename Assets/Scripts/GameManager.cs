using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Thought[] thoughts;
	public float minWait, maxWait, impatient, interval, maxWaitDecrease;
	public static int score, sADD;
	public TextMesh text;
	public bool gameplaying = true;
	private bool isCrazy = false;
	private float wait;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		score = 0;
		wait = maxWait;
		StartCoroutine("thinkHarder");
		StartCoroutine("distract");
	}


	IEnumerator thinkHarder(){
		while(maxWait > minWait){
			if(isCrazy){
				isCrazy = !isCrazy;
				wait = maxWait;
				yield return  new WaitForSeconds(interval);
			}
			else if(wait < minWait){
				isCrazy = true;
				maxWait -= maxWaitDecrease;
				wait = minWait;
				float temp = 1f + Random.value*2f;
				yield return  new WaitForSeconds(temp);
			}
			else{
				wait -= impatient;
				yield return  new WaitForSeconds(interval);
			}
		}
	}

	IEnumerator distract(){
		while(gameplaying){
			SpawnThought();
			yield return new WaitForSeconds(wait);
		}
	}

	void SpawnThought(){
		Vector3 spawnplace = spawnPoints[(int)UnityEngine.Random.Range(0,spawnPoints.Length)].position;
		Thought thought = thoughts[(int)UnityEngine.Random.Range(0,thoughts.Length)];
		GameObject.Instantiate(thought,spawnplace,Quaternion.identity);
	}



	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " +score;
	}
}
