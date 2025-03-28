using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{

    public GameObject howToPlayButton;

    void Start()
    {
        if (howToPlayButton != null)
        {
            UnityEngine.UI.Button button = howToPlayButton.GetComponent<UnityEngine.UI.Button>();
            if (button != null)
            {
                button.onClick.AddListener(OpenHowToPlayScene);
            }
        }
    }

    public void OpenHowToPlayScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
