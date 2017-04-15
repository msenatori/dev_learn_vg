using UnityEngine;
using System.Collections;

public class DianaScript : MonoBehaviour {

	public ParticleSystem particle;
	public GameObject positionFire;
	private ParticleSystem fuego;


	void OnCollisionEnter(Collision col) {
		if (col.gameObject.GetComponent<Bullet>()) {
			fuego = (ParticleSystem) Instantiate (particle, positionFire.gameObject.transform.position, transform.rotation);
			Destroy (col.gameObject);
			StartCoroutine (Desactivate ());
		}
	}

	IEnumerator Desactivate() {
		yield return new WaitForSeconds (2);
		this.gameObject.SetActive(false);
	}
}
