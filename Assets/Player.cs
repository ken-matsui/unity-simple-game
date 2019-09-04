using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private Animator animator;
	public GameObject explosion;
	public Text scoreText;
	private int score = 0;
	public float speed = 0.01f;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Locomotion ();	
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "cola") {
			score++;
			scoreText.text = score.ToString();
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "apple") {
			Instantiate (explosion, this.transform.position, Quaternion.identity);
		}
	}

	void Locomotion() {
		 
		if (Input.GetKey ("up")) {
			transform.rotation = Quaternion.Euler (0, -90, 0);
			transform.position += transform.forward * speed;
			animator.SetBool ("is_running", true);
		} else {
			animator.SetBool ("is_running", false);
		}

		if (Input.GetKey ("right")) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
			transform.position += transform.forward * speed;
			animator.SetBool ("is_running", true);
		}

		if (Input.GetKey ("left")) {
			transform.rotation = Quaternion.Euler (0, 180, 0);
			transform.position += transform.forward * speed;
			animator.SetBool ("is_running", true);
		}

		if (Input.GetKey ("down")) {
			transform.rotation = Quaternion.Euler (0, 90, 0);
			transform.position += transform.forward * speed;
			animator.SetBool ("is_running", true);
		}


		if (transform.position.x < 0) {
			Vector3 pos = transform.position;
			pos.x = 0;
			transform.position = pos;
		}

		if (transform.position.z > 10) {
			Vector3 pos = transform.position;
			pos.z = 10;
			transform.position = pos;
		}
		if (transform.position.z < -10) {
			Vector3 pos = transform.position;
			pos.z = -10;
			transform.position = pos;
		}
	}
}
