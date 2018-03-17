using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstableSpawner : MonoBehaviour {
	public Obstacle obstaclePrefab;//障害物のPrefab
	public float spawnSpan;//生成の間隔時間
	public Vector2 heightRange;//土管の高さのランダム幅
	public Vector2 spaceRange;//土管の上下間隔のランダム幅

	private float spawnTimer;

	void Start(){
		spawnTimer = spawnSpan;
	}

	void Update () {
		// 生成待ち時間が終わったか
		if (spawnTimer >= spawnSpan) {
			spawnTimer = 0f;

			//ランダム位置に生成する
			Obstacle instance = Instantiate(obstaclePrefab);
			float height = Random.Range (heightRange.x, heightRange.y);
			float space = Random.Range (spaceRange.x, spaceRange.y);
			instance.Setup (height, space);
		}

		spawnTimer += Time.deltaTime;
	}
}
