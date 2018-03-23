using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController2 : MonoBehaviour {

	GameObject player;
    Vector3 Transrate = new Vector3(0, -0.1f, 0);
    float threshould = -5.0f;
    public float r1; // 矢の半径
    public float r2; // プレイヤの半径

	void Start() {
		this.player = GameObject.Find("player");
	}

	void Update() {
		transform.Translate(Transrate);
		if(transform.position.y < threshould) {
			Destroy(gameObject);
		}

		// 当たり判定
		Vector2 p1 = transform.position; // 矢の中心座標
		Vector2 p2 = this.player.transform.position; // プレイヤの中心座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;


		if(d < r1 + r2) {

			// 監督スクリプトにプレイヤと衝突したことを伝える
			GameObject director = GameObject.Find("GameDirector");
            if (gameObject.tag == "arrow1")
            {
                director.GetComponent<GameDirector>().DecreaseHp();
            }
            if (gameObject.tag == "arrow2")
            {
                director.GetComponent<GameDirector>().MaxHp();
            }

			// 衝突した場合は矢を消す
			Destroy(gameObject);
		}
	}
}