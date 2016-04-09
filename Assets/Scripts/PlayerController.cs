using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody _rigidbody;

	void Start() {
		_rigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate() {
		var count = Input.touchCount;
		for (int i = 0; i < count; i++) {
			Vector3 touchDeltaPosition = Input.GetTouch(i).deltaPosition;
			if (Input.touchCount > 0) {

				Vector3 moveDirection = new Vector3 (touchDeltaPosition.x, 0, touchDeltaPosition.y);
				moveDirection.y = 0;

				_rigidbody.AddForce (moveDirection * speed);

//				if (touchDeltaPosition.x > 0) {
//					_rigidbody.AddForce(Vector3.right * speed * Time.deltaTime * speed);
//					if (Input.GetTouch(0).phase == TouchPhase.Stationary) {
//						_rigidbody.AddForce(Vector3.right * speed * Time.deltaTime * speed);
//					}
//				}
//				if(touchDeltaPosition.x < 0) {
//					_rigidbody.AddForce(-Vector3.right * speed * Time.deltaTime * speed);
//					if (Input.GetTouch(0).phase == TouchPhase.Stationary) {
//						_rigidbody.AddForce(-Vector3.right * speed * Time.deltaTime * speed);
//					}
//				}
//				if (touchDeltaPosition.y > 0) {
//					_rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime * speed);
//					if (Input.GetTouch(0).phase == TouchPhase.Stationary) {
//						_rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime * speed);
//					}
//				}
//				if (touchDeltaPosition.y < 0) {
//					_rigidbody.AddForce(-Vector3.forward * speed * Time.deltaTime * speed);
//					if (Input.GetTouch(0).phase == TouchPhase.Stationary) {
//						_rigidbody.AddForce(-Vector3.forward * speed * Time.deltaTime * speed);
//					}
//				}
			}
		}
	}
}
