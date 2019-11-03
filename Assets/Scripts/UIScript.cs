using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public RedBallControl player;
    public Text coinText;
    public Text redKeyText;
    public Text blueKeyText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + player.coins;
        redKeyText.text = "Red Keys: " + player.redKeyCount;
        blueKeyText.text = "Blue Keys: " + player.blueKeyCount;
    }
}
