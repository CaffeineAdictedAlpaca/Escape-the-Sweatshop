using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Adrian
public class MainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button QuitButton;
    private void Start()
    {
        // Kollar efter click på knapparna för att aktivera funktion - Adrian
        Button start = StartButton.GetComponent<Button>();
        start.onClick.AddListener(StartGame);

        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitGame);
    }
    private void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    private void QuitGame()
    {
        Application.Quit();
    }
}
