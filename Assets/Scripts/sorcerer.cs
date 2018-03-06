using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorcerer : MonoBehaviour {

    Animator anim;

    GameObject knight;

    float posPl;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        knight = GameObject.FindWithTag("Player");

		
	}
	
	// Update is called once per frame
	void Update () {
		if (knight.transform.position.x > 1)
        {
            anim.SetBool("closeEnough", true);
        } else
        {
            anim.SetBool("closeEnough", false);
        }
	}
}
