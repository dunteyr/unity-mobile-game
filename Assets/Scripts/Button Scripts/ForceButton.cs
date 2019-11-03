using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceButton : MonoBehaviour
{
    public bool isButtonPressed = false;

    public void OnButtonPress()
    {
        isButtonPressed = true;
    }


}
