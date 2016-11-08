﻿using UnityEngine;
using System.Collections;

public class cat : MonoBehaviour {
	public Transform mouse;
	Vector3 directionToMouse;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (mouse == null) {
			return;
		}
		directionToMouse = mouse.position - transform.position;
		if (Vector3.Angle (transform.forward, directionToMouse) < 90f) {
			Ray catRay = new Ray (transform.position, directionToMouse);
			RaycastHit catRayHitInfo;
			if (Physics.Raycast (catRay, out catRayHitInfo, 25f)) {
				Debug.DrawRay (catRay.origin, catRay.direction * 100f, Color.blue);
				if (catRayHitInfo.collider.tag == "Mouse") {
					if (catRayHitInfo.distance <= 5f) {
						rb.AddForce (directionToMouse.normalized * 500f);
						Debug.Log ("chase");
					}
				}
			}
		}
	}
}
