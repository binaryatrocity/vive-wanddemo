using UnityEngine;
using System.Collections;

public class SpellController : MonoBehaviour {

	public bool isProjectile  = true;
	public float projectileSpeed = 20f;
	public float explosionRadius = 30f;
	public float explosionForce = 50f;
	public Vector3 startPosition = Vector3.forward;
	public Vector3 startDirection = Vector3.forward;

	public AudioSource castingAudio;
	public AudioSource collisionAudio;

	// Use this for initialization
	void Start () {
		transform.position = startPosition;
		castingAudio.Play();
	}

	// Update is called once per frame
	void Update () {
		if (isProjectile) {
			transform.Translate(startDirection * (projectileSpeed * Time.deltaTime));
		}
	}

	public void HandleCollision(GameObject obj, Collision c) {

		// play collision audio
		if (collisionAudio != null) {
			collisionAudio.Play();
		}
		
		// apply explosion, add particle effect here later?
		Debug.Log("[SpellController] Collision Detected");
		CreateExplosion(c.contacts[0].point, explosionRadius, explosionForce);
		Destroy(this.gameObject);
	}

	public static void CreateExplosion(Vector3 pos, float radius, float force) {
		if (force <= 0.0f || radius <= 0.0f) return;

		// add force to all colliders
		Collider[] objects = UnityEngine.Physics.OverlapSphere(pos, radius);
		foreach (Collider h in objects) {
			Rigidbody r = h.GetComponent<Rigidbody>();
			if (r != null) r.AddExplosionForce(force, pos, radius);
		}
	}
}
