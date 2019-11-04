using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CMCameraScript : MonoBehaviour
{
    public GameObject playerObject;
    Transform playerTransform;
    Rigidbody2D playerRB;
    LensSettings lensSettings;
    public CinemachineVirtualCamera virtCamera;
    float zv;
    public float smoothFactor;
    

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerTransform = playerObject.GetComponent<Transform>();
        playerRB = playerObject.GetComponent<Rigidbody2D>();

        virtCamera.Follow = playerTransform;

        zv = playerRB.velocity.magnitude + 10;
        smoothFactor = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //lensSettings.OrthographicSize = playerRB.velocity;
        if (playerRB != null)
        {
            //Debug.Log("Orthographic Size: " + lensSettings.OrthographicSize + " Velocity of Player: " + playerRB.velocity);
            virtCamera.m_Lens.OrthographicSize = virtCamera.m_Lens.OrthographicSize + smoothFactor * ((playerRB.velocity.magnitude + 10) - virtCamera.m_Lens.OrthographicSize);
        }

    }
}
