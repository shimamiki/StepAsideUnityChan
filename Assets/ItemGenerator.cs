﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	//carPrefabをいれる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;

	//アイテムをだすｘ方向の範囲
	private float posRange = 3.4f;



	////Unityちゃんのオブジェクトを取得
	public GameObject UnityChan;




	// Use this for initialization
	void Start () {

		////Unityちゃんのオブジェクトを取得
		UnityChan = GameObject.Find("unitychan");



		////まず-160地点から-120地点まで生成しておく
		for(int i = startPos ; i < startPos + 70 ; i+=15){
			//どのアイテムを出すのかランダムに設定
			int num = Random.Range (1,11);
			if (num <= 2) {
				//コーンをX軸方向に一直線に生成
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
				}
			} else {
				//レーン毎にアイテム生成
				for(int j = -1; j<=1;j++){
					//アイテムの種類を決める
					int item = Random.Range (1,11);
					//アイテムを置くｚ座標のオフセットをらんだむに設定
					int offsetZ = Random.Range(-5,6);
					//60%コイン配置：30%車配置：10％何もなし
					if (1 <= item && item <= 6) {
						//コインを生成
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
					} else if (7 <= item && item <= 9) {
						//クルマを生成
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
					}

				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (UnityChan.transform.position.z >= startPos + 30) {
		
			for (int i = startPos + 70; i < startPos + 100; i += 15) {
				//どのアイテムを出すのかランダムに設定
				int num = Random.Range (1, 11);
				if (num <= 2) {
					//コーンをX軸方向に一直線に生成
					for (float j = -1; j <= 1; j += 0.4f) {
						GameObject cone = Instantiate (conePrefab) as GameObject;
						cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
					}
				} else {
					//レーン毎にアイテム生成
					for (int j = -1; j <= 1; j++) {
						//アイテムの種類を決める
						int item = Random.Range (1, 11);
						//アイテムを置くｚ座標のオフセットをらんだむに設定
						int offsetZ = Random.Range (-5, 6);
						//60%コイン配置：30%車配置：10％何もなし
						if (1 <= item && item <= 6) {
							//コインを生成
							GameObject coin = Instantiate (coinPrefab) as GameObject;
							coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
						} else if (7 <= item && item <= 9) {
							//クルマを生成
							GameObject car = Instantiate (carPrefab) as GameObject;
							car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
						}

					}
				}
			}
			startPos = startPos + 30;
		}
	}
}
