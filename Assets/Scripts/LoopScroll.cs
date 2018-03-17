using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScroll : MonoBehaviour
{
	public float speed;		//移動スピード
	public float loopStart;	//ループ開始位置
	public float loopEnd;	//ループ終了位置
	  
	void Update ()
	{
		Vector3 pos = transform.position;
		// ループ処理
		if (pos.x <= loopEnd) {
			pos.x += loopStart - loopEnd;
		}

		// 移動処理
		pos.x -= speed * Time.deltaTime; 
		transform.position = pos;
	}
}

