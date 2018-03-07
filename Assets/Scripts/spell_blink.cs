using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell_blink : MonoBehaviour
{
    Collider2D coli2d;
    Transform trans;
    Animator anim;

    private void OnTriggerEnter2D(Collider2D coli2d)
    {
        trans = GetComponentInParent<Transform>();
        trans.position = new Vector2(-1, 0);
    }

    private void OnTriggerExit2D(Collider2D coli2d)
    {
        anim = GetComponentInParent<Animator>();
        anim.SetBool("closeEnough", false);
    }
}
