using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenPikeScript : MonoBehaviour
{
    public GameObject particlesObject;
    public ParticleSystem finishParticles;
    public RedBallControl player;
    public Canvas levelCompleteCanvas;
    bool hasTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<RedBallControl>();
        //levelCompleteCanvas = GameObject.FindGameObjectWithTag("LevelComplete").GetComponent<Canvas>();
        particlesObject = GameObject.FindGameObjectWithTag("Finish Particles");

        //finishParticles = particlesObject.GetComponent<ParticleSystem>();
        Debug.Log(levelCompleteCanvas);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player" && hasTriggered == false)
        {
            finishParticles.Play();
            hasTriggered = true;
            player.coins += 30;

            levelCompleteCanvas.enabled = true;
        }
    }
}
