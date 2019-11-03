using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemForceButton : MonoBehaviour
{
    public bool isRButtonPressed = false;
    public ForceButton forceButton;
    public RightButton rightForceButton;
    public LeftButton leftForceButton;
    
    public void onRButtonPressed()
    {
        isRButtonPressed = true;
        forceButton.isButtonPressed = false;
        rightForceButton.isButtonPressed = false;
        leftForceButton.isButtonPressed = false;
    }
}
