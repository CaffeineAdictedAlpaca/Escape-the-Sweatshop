using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button SettingsButton;
    public Button QuitButton;
    private void Start()
    {
        Button start = StartButton.GetComponent<Button>();
        start.onClick.AddListener(StartGame);
        Button settings = SettingsButton.GetComponent<Button>();
        settings.onClick.AddListener(Settings);
        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitGame);
    }
    private void StartGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
    private void Settings()
    {

    }
    private void QuitGame()
    {
        Application.Quit();
    }
}
