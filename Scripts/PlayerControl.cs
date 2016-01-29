using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float moveSpeed = 1.0f;
	private Rigidbody body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var moveInput = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		var camera = Camera.main.transform;

		var rotatedMove = Quaternion.Euler (0, camera.rotation.eulerAngles.y, 0) * moveInput;

		body.MovePosition(transform.position + rotatedMove * Time.smoothDeltaTime * moveSpeed);
	}
}
