using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject settingsButton;
    void Start()
    {
        if (settingsButton != null)
        {
            UnityEngine.UI.Button button = settingsButton.GetComponent<UnityEngine.UI.Button>();
            if (button != null)
            {
                button.onClick.AddListener(OpenSettingsScene);
            }
        }
    }

    public void OpenSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }
}