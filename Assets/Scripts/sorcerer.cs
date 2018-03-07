using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorcerer : MonoBehaviour {

    float speed;

	// Use this for initialization
	void Start () {
        speed = 0.1f;

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
