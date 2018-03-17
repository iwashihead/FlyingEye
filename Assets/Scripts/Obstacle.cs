using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	const float RightEndOfDisplay = 12f;//画面右端座標
	const float LeftEndOfDisplay = -12f;//画面左端座標

	public float speed;		//移動スピード
	public GameObject top;
	public GameObject bottom;

	void Update () {
		Vector3 pos = transform.position;

		//画面左端へ到達したら消滅する
		if (pos.x <= LeftEndOfDisplay) {
			Destroy (gameObject);
			return;
		}

		// 移動処理
		pos.x -= speed * Time.deltaTime; 
		transform.position = pos;
	}

	public void Setup(float height, float space)
	{
		//初期位置
		transform.position = new Vector3(RightEndOfDisplay, height, 0f);

		//上下の幅
		top.transform.localPosition = new Vector3(top.transform.localPosition.x, 
			space * 0.5f, top.transform.localPosition.z);
		bottom.transform.localPosition = new Vector3(bottom.transform.localPosition.x,
			-space * 0.5f, bottom.transform.localPosition.z);
	}
}
