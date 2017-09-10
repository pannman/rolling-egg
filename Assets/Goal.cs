using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	public GameObject fire;
	public GameObject camera2;
	public GameObject egg;
	public GameObject camera;
	public GameObject Radar;
	public GameObject fly;
	public GameObject a;
	public GameObject me;
	public GameObject tex;
	public GameObject boto;
	int speed = 40;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (egg.activeInHierarchy == false && camera2.transform.position.z < 10.7f) {
			camera2.transform.RotateAround (fly.transform.position, Vector3.right, speed * Time.deltaTime);
			Debug.Log ("YG");
		}
		if (camera2.transform.position.z > 10.6f) {
			Invoke("texte",1);
			boto.SetActive (true);
		}
	}
	void OnCollisionEnter(Collision collision) {
		egg.transform.position = new Vector3 (8.6f, 2, 10.2f);
		fire.SetActive (true);
		Invoke ("EggDestroy", 5f);
		camera.SetActive (false);
		Radar.SetActive (false);
		camera2.SetActive (true);
		a.SetActive (false);
		me.SetActive (true);
		boto.SetActive (false);
		//	camera2.transform.position = new Vector3(-8.5f,2,6.38f);
		//camera.transform.position = new Vector3(0,0,0);
//		egg.transform.rotation = new Vector3();
		//Invoke ("camera22",5);

	}
	void EggDestroy (){
		egg.SetActive (false);
	}
	void texte (){
		tex.SetActive (true);
	}
//	void camera22(){
//		camera2.transform.RotateAround (fly.transform.position, Vector3.right, speed * Time.deltaTime);
//	}
}
