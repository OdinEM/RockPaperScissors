using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoose : MonoBehaviour
{
    // 0 is Rock, 1 is Paper, 2 is Scissors

    public Sprite[] spritesToChooseFrom;

    public Button rockButton;
    public Button paperButton;
    public Button scissorsButton;

    public int playerChoose = -1;

    public TextMeshProUGUI playerChooseText;

    public void RockButton()
    {
        playerChoose = 0;
        playerChooseText.text = "You Chose Rock!";
        rockButton.gameObject.SetActive(false); paperButton.gameObject.SetActive(false); scissorsButton.gameObject.SetActive(false);
    }

    public void PaperButton()
    {
        playerChoose = 1;
        playerChooseText.text = "You Chose Paper!";
        rockButton.gameObject.SetActive(false); paperButton.gameObject.SetActive(false); scissorsButton.gameObject.SetActive(false);
    }

    public void ScissorsButton()
    {
        playerChoose = 2;
        playerChooseText.text = "You Chose Scissors!";
        rockButton.gameObject.SetActive(false); paperButton.gameObject.SetActive(false); scissorsButton.gameObject.SetActive(false);
    }


}
