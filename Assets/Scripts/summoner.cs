using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summoner : MonoBehaviour {

    string debugmessage;


    Animator anim;

    public GameObject knight;

    public float posX;
    public float posPl;

    public float currentDistance;
    public float storedDistance;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        knight = GameObject.FindWithTag("Player");



        storedDistance = posPl - posX;

        
    }

    // Update is called once per frame
    void Update () {

        posX = transform.position.x;
        posPl = knight.transform.position.x;
        currentDistance = (posX - posPl) ;
        debugmessage = "Position of Summoner:" + posX + "\n" + "Position of Player" + posPl;
        DebugGUIdistance();
        storedDistance = currentDistance;
        if (posPl <= (posX +1))
        {
            anim.SetBool("closeEnough", true);
            Debug.Log(anim.GetBool("closeEnough"));
        } else
        {
            anim.SetBool("closeEnough", false);
            Debug.Log(anim.GetBool("closeEnough"));
        }

    }

    void DebugGUIdistance ()
    {
        if (storedDistance != currentDistance)
        {
            DebugConsole.Clear();
            DebugConsole.Log(debugmessage);
            DebugConsole.Log("\n \n Current distance: " + storedDistance.ToString());
            DebugConsole.Log("\n \n \n Current vector: " + Vector2.Distance(transform.position, knight.transform.position));
        }
    }
}
