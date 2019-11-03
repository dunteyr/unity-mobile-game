using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public bool isButtonPressed = false;
    public RightButton rightForceButton;

    public void OnButtonPress()
    {
        isButtonPressed = true;
        rightForceButton.isButtonPressed = false;
    }
}
