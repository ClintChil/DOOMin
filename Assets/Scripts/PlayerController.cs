using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody _rigidbody;

	void Start() {
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate() {
		Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		moveDirection = Camera.main.transform.TransformDirection(moveDirection);
		moveDirection.y = 0;
		_rigidbody.AddForce(moveDirection * speed);
	}
}
