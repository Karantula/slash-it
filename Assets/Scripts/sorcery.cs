using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorcery : MonoBehaviour {

    Collider2D coli2d;
    Animator anim;

    private void OnTriggerEnter2D(Collider2D coli2d)
    {
        anim = GetComponentInParent<Animator>();
        if (coli2d.gameObject.tag == "Player")
        {
            anim.SetBool("closeEnough", true);
        }
    }

    private void OnTriggerExit2D(Collider2D coli2d)
    {
        anim = GetComponentInParent<Animator>();
        anim.SetBool("closeEnough", false);
    }
}
