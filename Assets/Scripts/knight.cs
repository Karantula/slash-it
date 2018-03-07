using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour {

    float speed = 1.0f;

    public Animator m_Animator;

    // Use this for initialization
    void Start() {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        SimpleMoves();

    }

    void SimpleMoves()
    {
        var move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            m_Animator.SetInteger("attacking", 0);
            m_Animator.SetInteger("blocking", 0);

            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                m_Animator.SetInteger("walking", 1);
                transform.eulerAngles = new Vector3(0, 180, 0);
            } else if (Input.GetAxisRaw("Horizontal")== 1) {
                m_Animator.SetInteger("walking", 1);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
        else if ((Input.GetButton("Fire1")) || (Input.GetKey("e")))
        {
            m_Animator.SetInteger("attacking", 1);
            Debug.Log("Attacking!");
            m_Animator.SetInteger("walking", 0);
            m_Animator.SetInteger("blocking", 0);
        }
        else if ((Input.GetButton("Fire2")) || (Input.GetKey("q")))
        {
            //speed = 0.2f;
            m_Animator.SetInteger("blocking", 1);
            Debug.Log("Blocking!");
            m_Animator.SetInteger("attacking", 0);
            m_Animator.SetInteger("walking", 0);
        }
        else if (Input.GetKey("p"))
        {
            m_Animator.SetInteger("dying", 1);
            Debug.Log("Dying!");
        }
        else
        {
            m_Animator.SetInteger("attacking", 0);
            m_Animator.SetInteger("walking", 0);
            m_Animator.SetInteger("blocking", 0);
            m_Animator.SetInteger("dying", 0);
            speed = 1.0f;

        }
    }   
}
