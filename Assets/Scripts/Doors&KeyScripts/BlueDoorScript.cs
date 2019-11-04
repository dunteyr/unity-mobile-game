using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoorScript : MonoBehaviour
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
        if(collision.gameObject.tag == "Player" && playerScript.blueKeyCount > 0)
        {
            playerScript.blueKeyCount -= 1;
            DoorClose();

        }
    }
    public void DoorClose()
    {
        anim.SetBool("isUnlocked", true);
    }
}
