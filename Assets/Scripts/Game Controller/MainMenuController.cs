using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    [SerializeField] private Button _muteButton;
    [SerializeField] private Sprite[] _muteIcons;

    public void StartGame()
    {
        GameManager.instance.gameStartedFromMainMenu = true;
        SceneFader.instance.FadeToLoadScene("Gameplay");
    }

    private void CheckToPlayMusic()
    {
        if (GamePreferences.GetMusicState() == 0)
        {
            if (MusicController.instance != null)
            {
                MusicController.instance.PlayMusic(true);
            }
            _muteButton.image.sprite = _muteIcons[1];
        }
        else
        {
            _muteButton.image.sprite = _muteIcons[0];
        }
    }

    public void ShowOptions()
    {
        SceneFader.instance.FadeToLoadScene("Options");
    }

    public void ShowHighScore()
    {
        SceneFader.instance.FadeToLoadScene("HighScore");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ToggleMute()
    {
        if (GamePreferences.GetMusicState() == 0)
        {
            GamePreferences.SetMusicState(1);
            if (MusicController.instance != null)
            {
                MusicController.instance.PlayMusic(false);
            }
            _muteButton.image.sprite = _muteIcons[0];
        }
        else
        {
            GamePreferences.SetMusicState(0);
            if (MusicController.instance != null)
            {
                MusicController.instance.PlayMusic(true);
            }
            _muteButton.image.sprite = _muteIcons[1];
        }
    }
}
