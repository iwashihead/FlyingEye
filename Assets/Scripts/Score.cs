using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text textScore;

	int score;

	void Start() {
		Reset ();
	}

	public void Reset() {
		score = 0;
		textScore.text = score.ToString ("D6");
	}

	public void Add(int scoreValue) {
		score += scoreValue;
		textScore.text = score.ToString ("D6");
	}
}
