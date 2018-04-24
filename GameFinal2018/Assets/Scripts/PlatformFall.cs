using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour {
	public float fallDelay = 4f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {
		rb2d = GetComponent<Rigidbody2D>();
		
	}
	
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision other)
	{
		if (other.gameObject.CompareTag("Player")
		rb2d.isKinematic = false;
	}
}
