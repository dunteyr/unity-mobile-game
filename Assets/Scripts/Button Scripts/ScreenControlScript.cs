using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenControlScript : MonoBehaviour
{
    public bool isForceButtonPressed = false;
    public bool isRemForceButtonPressed = false;
    public bool isRightButtonPressed = false;
    public bool isLeftButtonPressed = false;

    void Start()
    {

    }

    public void OnForceButtonPress()
    {
        isForceButtonPressed = true;
    }


    public void onRemForceButtonPress()
    {
        isRemForceButtonPressed = true;
        isForceButtonPressed = false;
        isRightButtonPressed = false;
        isLeftButtonPressed = false;
    }

    public void OnRightButtonPress()
    {
        isRightButtonPressed = true;
        isLeftButtonPressed = false;
    }

    public void OnLeftButtonPress()
    {
        isLeftButtonPressed = true;
        isRightButtonPressed = false;
    }

}
