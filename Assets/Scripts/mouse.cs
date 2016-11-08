using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {
	public Transform cat;
	Vector3 directionToCat;
	public Rigidbody rb;
	public float thrust=20f;
	public AudioSource run;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		directionToCat = cat.position - transform.position;
		if (Vector3.Angle (transform.forward, directionToCat) < 180f) {
			Ray mouseRay = new Ray (transform.position, directionToCat);
			RaycastHit mouseRayHitInfo;
			if(Physics.Raycast(mouseRay, out mouseRayHitInfo, 25f)){
				//Debug.DrawRay (mouseRay.origin, mouseRay.direction * 100f, Color.red);
				if(mouseRayHitInfo.collider.tag=="Cat"){
					rb.AddForce (-directionToCat.normalized * 300f);
					run.Play ();
					Debug.Log ("fear");
				}
				
		}
	}
}
					}
