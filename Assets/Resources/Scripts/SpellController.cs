using UnityEngine;
using System.Collections;

public class SpellController : MonoBehaviour {

	public bool isProjectile  = false;
	public float projectileSpeed = 20f;
	public Vector3 startPosition = Vector3.forward;
	public Vector3 startDirection = Vector3.forward;

	public AudioSource castingAudio;

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
}
