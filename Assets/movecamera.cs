using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movecamera : MonoBehaviour {

//	public float camerax;
//	public float movex;
	public float cameray;
//	public float movey;
//	public int speed = 20;
//	float cx;
//	float cy;
	public GameObject player;
	public Vector3 cam3;
	public Quaternion cam4;
	public GameObject egg;

	Quaternion quat;
	int speed = 100;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		float acce = Input.acceleration.x * 1;
		//Debug.Log (acce);
		if(acce > 0){
			transform.RotateAround (player.transform.position, Vector3.up, speed * Time.deltaTime * acce);

		}
		if (acce < 0) {
			transform.RotateAround (player.transform.position, Vector3.up , speed * Time.deltaTime * acce);

		}

//		if (Input.GetMouseButtonDown (0)) {
//			cam3 = this.transform.position;
//			transform.LookAt (player.transform.position);
//		}
//
//		if (Input.GetMouseButton (0)) {
//			if (this.transform.position.y > player.transform.position.y + 0.3f) {
//				transform.RotateAround (player.transform.position, transform.right, -speed * Time.deltaTime);			
//			}
//		}
//	//		transform.rotation = Quaternion.Slerp (transform.rotation,new Quaternion(quat.x - 30,quat.y,quat.z,quat.w), 0.5f * Time.deltaTime);
////		}
////
//		if (Input.GetMouseButtonUp (0)) {
//			this.transform.position = player.transform.position + new Vector3 (0, 1.6f, -1);
//			transform.LookAt (egg.transform.position);
////			transform.rotation = quat;
//		}

//		}

	//	if (Input.GetMouseButtonDown (0)) {
			
//			camerax = Input.mousePosition.x;
		//	Quaternion.Slerp(transform.rotatio.
			//}

//

//	
	//	if (Input.GetMouseButton (0)) {
	//		this.transform.Rotate = new Vector3(127.7f, 180, -180);
//			//movex = Camera.ScreenToWorldPoint (Input.mousePosition).x; 
//			movex = Input.mousePosition.x;
//			//movey = Camera.ScreenToWorldPoint (Input.mousePosition).y; 
//			movey = Input.mousePosition.y;
//		
//			cx = camerax - movex;
//			cy = cameray - movey;
//			//Debug.Log (movex);
//			//Debug.Log (cy);
//			//Debug.Log (cx);
//			//if(cx >= 0){
//				//Debug.Log ("BHOOOGOOB");
//			transform.LookAt (player.transform.position);
//			transform.RotateAround (player.transform.position, Vector3.up, speed * Time.deltaTime);
//}
//			if(cx >= 0 && cy <= 0){
//				this.transform.RotateAround (player.transformj.positon, this.transform.up * speed);
//			}
//			if(cx >= 0 && cy >= 0){
//				this.transform.RotateAround (player.transformj.positon, this.transform.up * speed);
//			}
//			if(cx >= 0 && cy >= 0){
//				this.transform.RotateAround (player.transformj.positon, this.transform.up * speed);
//			}
		}
  }

