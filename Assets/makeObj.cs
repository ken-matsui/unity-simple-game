using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeObj : MonoBehaviour {

	public GameObject cola;
	public GameObject apple;

	private float timeleft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//だいたい1秒ごとに処理を行う
		timeleft -= Time.deltaTime;
		if (timeleft <= 0.0) {
			timeleft = 0.3f;

			//ここに処理
			float z = Random.Range (-5.0f, 5.0f);
			Instantiate (cola, new Vector3 (-20, 30, z), Quaternion.identity);
			z = Random.Range (-5.0f, 5.0f);
			Instantiate (apple, new Vector3 (-20, 30, z), Quaternion.identity);
		}
	}
}
