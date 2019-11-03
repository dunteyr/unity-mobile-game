using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    public bool isButtonPressed = false;
    public LeftButton leftForceButton;

    public void OnButtonPress()
    {
        isButtonPressed = true;
        leftForceButton.isButtonPressed = false;
    }
}
