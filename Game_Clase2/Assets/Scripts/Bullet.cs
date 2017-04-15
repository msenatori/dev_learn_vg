using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (destroy ());
	}
	
	IEnumerator destroy() {
		yield return new WaitForSeconds (5);
		Destroy (this.gameObject);
	}
}
