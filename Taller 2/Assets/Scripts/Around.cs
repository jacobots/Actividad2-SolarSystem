using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour {
	public float speed;
	public Transform sunPivot;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		this.transform.RotateAround (sunPivot.position, Vector3.up, speed);

	}
}
