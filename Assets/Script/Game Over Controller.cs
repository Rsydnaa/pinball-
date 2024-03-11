using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;

    private void Start()
    {
        if (mainMenuButton != null)
        {
            mainMenuButton.onClick.AddListener(MainMenu);
        }
        else
        {
            Debug.LogError("MainMenuButton is not assigned in the inspector.");
        }
    }

    private void MainMenu()
    {
        // Unload unused assets to free up memory (optional).
        Resources.UnloadUnusedAssets();

        // Load the "Main Menu" scene.
        SceneManager.LoadScene("Main Menu");
    }
}