using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	float velocity;
	float turn;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		 rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		turn = Random.value;
		//RaycastHit hit;
		rb.velocity = transform.forward * 10f + Physics.gravity;
		Ray moveRay = new Ray (transform.position, transform.forward);
		if(Physics.SphereCast(moveRay,.5f, .5f)){
			Debug.DrawRay(moveRay.origin, moveRay.direction*1000f, Color.yellow);
			if (turn > .5f) {
				transform.Rotate (0f, 90f, 0f);	
			}else if(turn<.5f){
				transform.Rotate (0f, -90f, 0f);
	}
			}}
}