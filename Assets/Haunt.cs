using UnityEngine;
using System.Collections;

public class Haunt : MonoBehaviour {
	public GameObject targetPlayer;
	public float speed = 1.0f;

	void Start() {
		LookAtTarget();
	}

	void Update() {
		LookAtTarget();
		MoveTowardsTarget();
	}

	void LookAtTarget() {
		//FIXME find a less CPU intensive way of billboarding sprite?
		//FIXME make sprite look at player camera. Sprite is looking at player's belly.
		transform.LookAt(targetPlayer.transform.position, targetPlayer.transform.up);
	}

	void MoveTowardsTarget() {
		transform.Translate(0, 0, speed * Time.deltaTime);
	}
}
