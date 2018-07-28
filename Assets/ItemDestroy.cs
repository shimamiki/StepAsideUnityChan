using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {


	public GameObject[] coins;
	public GameObject[] cars;
	public GameObject[] cones;

	public GameObject UnityChan;

	// Use this for initialization
	void Start () {

		coins = GameObject.FindGameObjectsWithTag("CoinTag");
		for (int i = 0; i < coins.Length; i++) {
			Debug.Log (coins[i].name );
		}
		cars = GameObject.FindGameObjectsWithTag("CarTag");
		cones = GameObject.FindGameObjectsWithTag("TrafficConeTag");

		UnityChan = GameObject.Find ("unitychan");

		
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < coins.Length; i++) {
			if (UnityChan.transform.position.z > coins [i].transform.position.z) {
				Destroy (coins[i].gameObject);
			}
		}

		for (int i = 0; i < cars.Length; i++) {
			if (UnityChan.transform.position.z > cars [i].transform.position.z) {
				Destroy(cars[i].gameObject);
			}
		}

		for (int i = 0; i < cones.Length; i++) {
			if (UnityChan.transform.position.z > cones [i].transform.position.z) {
				Destroy (cones[i].gameObject);
			}
		}



		
	}
}
