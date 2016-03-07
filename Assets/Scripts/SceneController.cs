using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	[SerializeField] private GameObject emojiManPrefab;
	private GameObject _enemy;
	private GameObject _emojiMan;

	void Start () {
	
	}
	
	void Update () {
		if(_enemy == null) {
			_enemy = Instantiate(enemyPrefab) as GameObject;
			_enemy.transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			_enemy.transform.Rotate(0, angle, 0);
		}

//		if(_emojiMan == null) {
//			_emojiMan = Instantiate(emojiManPrefab) as GameObject;
//			_emojiMan.transform.position = new Vector3(0, 4, 0);
//		}
	}
}
