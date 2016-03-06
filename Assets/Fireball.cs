using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {

	public float speed = 10.0f;
	public int damagae = 1;

	void Update() {
		transform.Translate(0, 0, speed * Time.deltaTime);
	}
	
	void OnTrigger(Collider other) {
		PlayerCharacter player = other.GetComponent<PlayerCharacter>();
		if (player != null) {
			Debug.Log("Player hit");
			player.Hurt(damagae);
		}
		Destroy(this.gameObject);
	}
}
