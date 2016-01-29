using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public Transform player;
	public Vector3 targetPosition;
	public bool useTargetPosition = false;
	public float cameraSpeed = 1.0f;

	public Vector3 offset = new Vector3 (-5, 10, -5);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 target;
		if (useTargetPosition) {
			target = targetPosition;
		} else {
			target = player.position + offset;
		}
		var nextPosition = Vector3.Slerp (transform.position, target, Time.smoothDeltaTime * cameraSpeed);
		transform.position = nextPosition;
	}
}
