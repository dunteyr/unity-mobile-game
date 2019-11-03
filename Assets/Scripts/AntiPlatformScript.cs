using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPlatformScript : MonoBehaviour
{
    GameObject player;
    Collider2D playerCollider;
    RedBallControl playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCollider = player.GetComponent<Collider2D>();
        playerScript = player.GetComponent<RedBallControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(player);
        }
    }
}
