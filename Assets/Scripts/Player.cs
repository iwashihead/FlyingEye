using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	const string DangerTag = "danger";
	const string ScoreTag = "score";

	public float jump;
	public Score score;

	Animator animator;
    Rigidbody2D rigidbody2d;
	bool isDead;

    // Use this for initialization
    void Start () {
		animator = GetComponent<Animator> ();
        rigidbody2d = GetComponent<Rigidbody2D> ();
    }
    
    // Update is called once per frame
    void Update () {
        //入力チェック
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            //ジャンプ処理
			rigidbody2d.velocity = Vector2.up * jump;
			animator.Play ("Fly", 0, 0.4f);
        }
    }


	void OnTriggerEnter2D(Collider2D collider)
	{
		if (isDead) return;

		if (collider.tag.Equals(ScoreTag))
		{
			// スコアアップ
			score.Add(10);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (isDead) return;

		if (coll.gameObject.tag.Equals(DangerTag))
		{
			isDead = true;
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Title");
		}
	}
}

