using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoorScript : MonoBehaviour
{
    public RedBallControl playerScript;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && playerScript.redKeyCount > 0)
        {
            playerScript.redKeyCount -= 1;
            doorClose();

        }
    }
    public void doorClose()
    {
        anim.SetBool("isUnlocked", true);
    }
}
