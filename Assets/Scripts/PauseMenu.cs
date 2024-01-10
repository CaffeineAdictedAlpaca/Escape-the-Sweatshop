using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Button ResumeButton;
    public Button SettingsButton;
    public Button QuitButton;
    GameObject[] buttons;
    private void Start()
    { 
        buttons = GameObject.FindGameObjectsWithTag("Buttons");
        Button resume = ResumeButton.GetComponent<Button>();
        resume.onClick.AddListener(ResumeGame);
        Button settings = SettingsButton.GetComponent<Button>();
        settings.onClick.AddListener(Settings);
        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitGame);
    }
    private void ResumeGame()
    {
        buttons[2].SetActive(false);
    }
    private void Settings()
    {

    }
    private void QuitGame()
    {
        Application.Quit();
    }
}
