using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public AudioClip myExplosion;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 5f);
		if (this.gameObject.transform.position.y >= 20f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("BANG");
		Destroy (other.gameObject);
		this.gameObject.GetComponent<AudioSource> ().Play();
		this.gameObject.GetComponent<AudioSource> ().clip = myExplosion;

	}
}
