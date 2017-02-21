using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {

	public GameObject myEnemy;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemy (1f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator SpawnEnemy(float waitTime) {
		
		/** Random the position that enemy will spawn */
		int spawnPointX = Random.Range(3, 10);
		int spawnPointY = Random.Range(5, 10);
		Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, 0);
		Instantiate (myEnemy, spawnPosition, Quaternion.identity);
		yield return new WaitForSeconds(waitTime);

		/** Random the spawn time of the enemy */
		StartCoroutine (SpawnEnemy (Random.Range(1,2)));
	}
}
