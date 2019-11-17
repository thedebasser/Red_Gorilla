using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public float fireRate = 0;
	public float Damage = 10;
	public LayerMask whatToHit;

	float timeToFire = 0;
	Transform firePoint;

	// Use this for initialization
	void Awake () {
		firePoint = transform.Find ("FirePoint");
		if (firePoint == null) {
		
			Debug.LogError ("No FirePoint");
		}

	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
		if (fireRate == 0) {
			if (Input.GetButtonDown ("Fire1")) {
				Shoot ();
			}
		} else {
			if (Input.GetButton ("Fire1") && Time.time > timeToFire) {

				timeToFire = Time.time + 1 / fireRate;
				Shoot ();
			}
		}
	}

	void Shoot () {

		Debug.Log ("Test");
		Vector2 firePointPosition = new Vector2 (firePoint.position.x, firePoint.position.y);
		RaycastHit2D hit = Physics2D.Raycast (firePointPosition, Vector2.right, 100, whatToHit);
		Debug.DrawLine (firePointPosition, (Vector2.right) * 100, Color.black);
		if (hit.collider != null) {
			Debug.DrawLine (firePointPosition, hit.point, Color.red);
		}
	}
}
