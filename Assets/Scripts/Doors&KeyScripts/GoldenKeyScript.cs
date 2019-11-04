using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKeyScript : MonoBehaviour 
{
    public UIScript UIScript;
    public CircleCollider2D playerCollider; //player collider that the trigger function checks
    public RedBallControl playerScript; //player script to change the key count in the trigger function
    public ParticleSystem collectParticles;
    public Gradient particleGradient;
    public GradientColorKey[] colorKey;
    public GradientAlphaKey[] alphaKey;
    public Color particleColor;

    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>();
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<RedBallControl>();
        collectParticles = ParticleSystem.FindObjectOfType<ParticleSystem>();
    }

    public Color SetColor(float r, float g, float b)
    {
        particleColor = new Color();
        //Divide by 255 to get a float between 0 and 1 for color values
        r = r / 255;
        g = g / 255;
        b = b / 255;

        particleColor.r = r;
        particleColor.g = g;
        particleColor.b = b;
        particleColor.a = 1;

        return particleColor;
    }
    //particle system requires gradient for the color
    public Gradient SetGradient(Color particleColor)
    {
        particleGradient = new Gradient();
        //to get gradient you do weird shit
        colorKey = new GradientColorKey[2];
        colorKey[0].color = particleColor;
        colorKey[0].time = 0.0f;
        colorKey[1].color = particleColor;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1f;
        alphaKey[1].time = 1f;

        particleGradient.SetKeys(colorKey, alphaKey);
        return particleGradient;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider == playerCollider)
        {
            playerScript.goldenKeyCount += 1;
            //UIScript.redKeyText.text = "Red Keys: " + playerScript.redKeyCount;
            //Get color to put into the gradient to get the gradient
            SetColor(255, 225, 105);
            SetGradient(particleColor);
            ParticleSystem createdParticles = Instantiate(collectParticles, gameObject.transform.position, Quaternion.identity); //create copy of particle system
            //get variable for the color module, enable it and set the color to the gradient
            var colorModule = createdParticles.colorOverLifetime;
            colorModule.enabled = true;
            colorModule.color = particleGradient;

            createdParticles.Play();
            Destroy(gameObject);
        }
    }
}
