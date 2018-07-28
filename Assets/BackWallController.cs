using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWallController : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//UnityちゃんとBackWallの距離
	private float difference;



	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//unityちゃんとBackWallのzの差
		this.difference = unitychan.transform.position.z - this.transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
		//unityチャンの位置に合わせてBackWallの位置を移動する
		this.transform.position = new Vector3(0,this.transform.position.y, this.unitychan.transform.position.z - difference);
		
	}


	//トリガーモードでほかのオブジェクトと接触した場合
	void OnTriggerEnter(Collider other){

		//Debug.Log ("あああああ");
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" ||  other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);
		}

	}
}
	