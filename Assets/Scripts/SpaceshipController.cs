using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

	public Color colorStart = Color.blue;
	public Color colorEnd = Color.cyan;
	public float duration = 1.0F;
	public GameObject myBullet;
	public Renderer rend;
	GameObject Spaceship;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>(); //Give functionality to render
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis("Horizontal") != 0) {
			this.gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right * Time.deltaTime *5f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (myBullet, this.gameObject.transform.position, Quaternion.identity);
			// Change color when shoot the bullet from cyan to blue and blue to cyan.
			float lerp = Mathf.PingPong(Time.time, duration) / duration;
			rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
		}


	}
}
