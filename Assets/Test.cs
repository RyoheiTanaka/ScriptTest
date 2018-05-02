using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start() {
		// 配列の初期化
		int[] points = { 5, 90, 40, 60, 50 };

		// 配列の各要素の値を順番に表示
		for(int i = 0; i < points.Length; i++) {
			Debug.Log(points[i]);
		}

		// 配列の各要素の値を逆順に表示
		for(int j = points.Length - 1; j >= 0; j--) {
			Debug.Log(points[j]);
		}

		// Bossクラスのインスタンスを生成
		Boss boss = new Boss();

		// Magic関数を11回実行
		for(int k = 0; k < 11; k++) {
			boss.Magic();
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss {
	private int hp = 100;
	private int mp = 53;
	private int power = 25;

	public void Attack() {
		Debug.Log(this.power + "のダメージを与えた");
	}

	public void Defence(int damage) {
		Debug.Log(damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void Magic() {
		if(this.mp >= 5) {
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log("MPが足りないため魔法が使えない。");
		}
		
	}

}