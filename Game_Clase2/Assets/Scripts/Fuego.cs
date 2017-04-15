using UnityEngine;
using System.Collections;

public class Fuego : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (destroy ());
	}
	
	IEnumerator destroy() {
		yield return new WaitForSeconds (10);
		Destroy (this.gameObject);
	}
}
