using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Adrian
public class MainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button SettingsButton;
    public Button QuitButton;
    public GameObject MenuObjects;
    private void Start()
    {
        // Kollar efter click på knapparna för att aktivera funktion - Adrian
        Button start = StartButton.GetComponent<Button>();
        start.onClick.AddListener(StartGame);

        Button settings = SettingsButton.GetComponent<Button>();
        settings.onClick.AddListener(Settings);

        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitGame);
    }
    private void StartGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
        MenuObjects.SetActive(false);
    }
    private void Settings()
    {

    }
    private void QuitGame()
    {
        Application.Quit();
    }
    private void Update()
    {
        SceneManager.GetSceneByName("SampleScene");
        if ()
        {

        }
    }
}
