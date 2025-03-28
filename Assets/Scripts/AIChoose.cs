using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AIChoose : MonoBehaviour
{

    public Sprite[] sprites;

    public int aiChoose = -1;

    public Image aiImage;

    public PlayerChoose playerChoose;

    public TextMeshProUGUI winText;

    public Button resetButton;

    public void PlayButton()
    {
        aiImage.gameObject.SetActive(true);
        aiChoose = Random.Range(0, sprites.Length);

        aiImage.sprite = sprites[aiChoose];

        if(aiChoose == playerChoose.playerChoose)
        {
            winText.text = "You Tied!";
        }

        if(aiChoose == 0 && playerChoose.playerChoose == 2 || aiChoose == 1 && playerChoose.playerChoose == 0 || aiChoose == 2 && playerChoose.playerChoose == 1)
        {
            winText.text = "You Lost!";
        }

        if (playerChoose.playerChoose == 0 && aiChoose == 2 || playerChoose.playerChoose == 1 && aiChoose == 0 || playerChoose.playerChoose == 2 && aiChoose == 1)
        {
            winText.text = "You Won!";
        }

        resetButton.gameObject.SetActive(true);
    }

    public void ResetButton()
    {
        aiChoose = -1;
        playerChoose.playerChoose = -1;
        playerChoose.rockButton.gameObject.SetActive(true);
        playerChoose.paperButton.gameObject.SetActive(true);
        playerChoose.scissorsButton.gameObject.SetActive(true);
        winText.text = "";
        playerChoose.playerChooseText.text = "";
        aiImage.sprite = null;
        resetButton.gameObject.SetActive(false);

    }
}
