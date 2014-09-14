using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Thought[] thoughts;
	public float minWait, maxWait, impatient, interval, loseItChance, maxWaitDecrease;
	public static int score, sADD;
	public bool gameplaying = true;
	private bool isCrazy = false;
	private float wait;
	public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
		wait = maxWait;
	}


	IEnumerator thinkHarder(){
		while(maxWait > minWait){
			if(Random.value < loseItChance){
				wait = 0;
			}
			if(isCrazy){
				isCrazy = !isCrazy;
				wait = maxWait;
				yield return  new WaitForSeconds(interval);
			}
			else if(wait < minWait){
				isCrazy = true;
				maxWait -= maxWaitDecrease;
				wait = minWait;
				float temp = .5f + Random.value*1.5f;
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



	
	// Update is called once per frame
	void Update () {
		
	}
}
