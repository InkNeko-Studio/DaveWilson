using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	public Transform[] enemyPositions;
	public float spawnTime;

	private void Start()
	{
		StartCoroutine(SpawnEnemy());
	}

	private IEnumerator SpawnEnemy()
	{
		while (true)
		{
			yield return new WaitForSeconds(spawnTime);
			int pIndex = Random.Range(0, enemyPositions.Length);
			Instantiate(enemy, enemyPositions[pIndex].position, Quaternion.identity);
		}
	}
}
