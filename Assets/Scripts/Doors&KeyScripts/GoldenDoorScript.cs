using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenDoorScript : MonoBehaviour
{
    public RedBallControl playerScript;
    Animator anim;

    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<RedBallControl>();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && playerScript.goldenKeyCount > 0)
        {
            playerScript.goldenKeyCount -= 1;
            doorClose();

        }
    }
    public void doorClose()
    {
        anim.SetBool("isUnlocked", true);
    }
}
