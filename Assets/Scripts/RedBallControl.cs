﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallControl : MonoBehaviour
{
    Touch touch;
    public Rigidbody2D rb2d;
    public Canvas buttonCanvas;
    Vector2 direction;
    public float forceAmount = 15f;
    public int redKeyCount;
    public int blueKeyCount;
    public int goldenKeyCount;
    public int coins;

    //public ForceButton forceButton;
    //public RemForceButton remForceButton;
    //public RightButton rightForceButton;
    //public LeftButton leftForceButton;

    public ScreenControlScript screenControlScript;


    // Start is called before the first frame update

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        buttonCanvas = GameObject.FindGameObjectWithTag("ScreenControls").GetComponent<Canvas>();
        screenControlScript = buttonCanvas.GetComponentInChildren<ScreenControlScript>();

        //forceButton = buttonCanvas.GetComponentInChildren<ForceButton>();
        //remForceButton = buttonCanvas.GetComponentInChildren<RemForceButton>();
        //rightForceButton = buttonCanvas.GetComponentInChildren<RightButton>();
        //leftForceButton = buttonCanvas.GetComponentInChildren<LeftButton>();


        coins = 0;
        redKeyCount = 0;
        blueKeyCount = 0;
        goldenKeyCount = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        //MoveOnTouch();
        if (screenControlScript.isForceButtonPressed == true)
        {
            rb2d.AddForce(Vector2.up * forceAmount);
        }
        if(screenControlScript.isRightButtonPressed == true)
        {
            rb2d.AddForce(Vector2.right * forceAmount);
        }
        if(screenControlScript.isLeftButtonPressed == true)
        {
            rb2d.AddForce(Vector2.left * forceAmount);
        }

    }
    void MoveOnTouch()
    {
        int touchCount = Input.touchCount;
        if (touchCount == 0)
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
        }
        if (touchCount > 0)
        {
            Physics2D.gravity = new Vector2(0, 0);
            touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            Vector2 touchPosition2d = touchPosition;
            rb2d.MovePosition(touchPosition2d);
            

        }
    }
}
