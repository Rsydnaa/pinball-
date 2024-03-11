using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
  public Button playButton;
  public Button exitButton;
  public Button creditButton;

  public void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    exitButton.onClick.AddListener(ExitGame);
    creditButton.onClick.AddListener(Credit);
  }

  public void PlayGame()
  {
    SceneManager.LoadScene("Pinball_Game");
  }

  public void ExitGame()
  {
    Application.Quit();
  }

  public void Credit()
  {
    SceneManager.LoadScene("Credit");
  }
}
