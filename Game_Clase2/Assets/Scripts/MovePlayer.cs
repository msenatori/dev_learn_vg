using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public KeyCode moveForward;
	public KeyCode moveBack;
	public KeyCode moveLeft;
	public KeyCode moveRight;
	public KeyCode fire;
	public KeyCode jump;

	public float speedMove;
	public float speedRotation;
	public float jumpForce;

	public GameObject bulletCanion;
	public GameObject bulletCanionPosition;

	private bool isGround = true;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveForward)) {
			transform.Translate (new Vector3 (0f, 0f, speedMove));
		} else if (Input.GetKey (moveBack)) {
			transform.Translate (new Vector3 (0f, 0f, -speedMove));
		}

		if (Input.GetKey (moveLeft)) {
			transform.Rotate (new Vector3 (0f, speedRotation, 0f));
		} else if (Input.GetKey (moveRight)) {
			transform.Rotate (new Vector3 (0f, -speedRotation, 0f));
		}

		if (Input.GetKeyDown (fire)) {
			GameObject instBullet = (GameObject)Instantiate (bulletCanion, bulletCanionPosition.transform.position, Quaternion.identity);
			instBullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 1000f);
		}

		if (isGround && Input.GetKeyDown (jump)) {
			this.GetComponent<Rigidbody> ().AddForce (transform.up * jumpForce);
			isGround = false;
		}
	}

	void OnCollisionEnter(Collision other) {
		isGround = true;
	}
}
