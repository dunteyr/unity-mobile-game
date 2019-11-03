using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    Collider2D playerCollider;
    UIScript UI;
    RedBallControl player;
    ParticleSystem collectParticles;

    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        UI = GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<RedBallControl>();
        collectParticles = GameObject.FindGameObjectWithTag("Particle System").GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider == playerCollider)
        {
            player.coins += 1;
            ParticleSystem createdParticles = Instantiate(collectParticles, gameObject.transform.position, Quaternion.identity);
            createdParticles.Play();
            UI.coinText.text = ("Coins: " + player.coins);
            Destroy(gameObject);
            
        }
    }
}
