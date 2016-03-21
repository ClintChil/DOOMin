using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody _rigidbody;
	private Touch _touch;

	void Start() {
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update() {

		if (Input.touchCount > 0) {
			_touch = Input.GetTouch(0);

//			Vector3 moveDirection = new Vector3(touchDelta.x, 0, touchDelta.y);

//			moveDirection = Camera.main.transform.TransformDirection(moveDirection);
//			moveDirection.y = 0;
//
//			_rigidbody.AddForce(moveDirection * speed);
		} 

//		Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));



	}
}
