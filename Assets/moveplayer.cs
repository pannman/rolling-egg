using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour {
	public GameObject player;
	private float  speed = 150.0f;
	public GameObject camera;
	//public Vector3 center = new Vector3 (0, 0, 0);
	//public Vector3 player;
//	float angle = 52.3f;
	// Use this for initialization
	public float a;
	public float b;
	public GameObject camera2;
	public GameObject egg;
	public GameObject texxx;
	public GameObject boo;
	void Start () {
		//GetComponent<Rigidbody> ().centerOfMass = center;
		//GetComponent<Rigidbody> ().centerOfMass = player;
		//player = GetComponent<Rigidbody>().centerOfMass;
	}

	// Update is called once per frame
	void Update () {
		
		
		//float di2r = camera.transform.forward.magnitude * Math.Cos (angle * (Math.PI / 180));	
		var dir = camera.transform.forward; //+ new Vector3 (0,0,di2r);       
		//double camz = Math.Cos (angle * (Math.PI / 180));
		//var dir2 = dir * camz;

		// ターゲット端末の縦横の表示に合わせてremapする
		//dir.z = Input.acceleration.y * camera.transform.position.z *  -1;
		//dir.x = Input.acceleration.x * -1;

		float gyro_y = Input.acceleration.y * 1;

	//	Debug.Log (player);
		// clamp acceleration vector to the unit sphere
	//	if (dir.sqrMagnitude > 1)
	//		dir.Normalize();

		// Make it move 10 meters per second instead of 10 meters per frame...
		//Debug.Log(gyro_y);
		if (gyro_y > -0.35f) {
			a = gyro_y + 0.35f;
			dir = dir * a * 1.2f * Time.deltaTime;
		}
		if (gyro_y < -0.35f) {
			b = gyro_y + 0.35f;
			dir = dir * -b * -0.78f * Time.deltaTime;
		}
		// Move object
		GetComponent<Rigidbody>().AddForce (dir * speed);



	}
	public void bom(){

//			this.transform.position = new Vector3 (-7.75f, 1.7f, -5.75f);
//			this.transform.rotation = new Quaternion(0,0,0,0);
//		camera.SetActive (true);
//		camera2.SetActive (false);
//		egg.SetActive (true);
//		texxx.SetActive (false);
//		boo.SetActive (false);
		SceneManager.LoadScene("main"); 

	}
}