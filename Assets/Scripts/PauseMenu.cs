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
        // Kollar efter click p� knapparna f�r att aktivera funktion - Adrian
        buttons = GameObject.FindGameObjectsWithTag("Buttons");
        Button resume = ResumeButton.GetComponent<Button>();
        resume.onClick.AddListener(ResumeGame);
        Button settings = SettingsButton.GetComponent<Button>();
        settings.onClick.AddListener(Settings);
        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitGame);
        buttons[2].SetActive(false);
    }
    void Update()
    {
        //Frys tiden och visa menyn om man trycker p� escape
        if (Input.GetKeyDown("escape") && Time.timeScale == 1)
        {
            Time.timeScale = 0;
            buttons[2].SetActive(true);
        }
        //Om tiden �r fryst g�m knapparna och ofrys den om man trycker escape igen - Adrian
        else if (Input.GetKeyDown("escape") && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            buttons[2].SetActive(false);
        }
    }
    // Om man klickar resume, g�m knapparna och resuma spelet - Adrian
    private void ResumeGame()
    {
        Time.timeScale = 1;
        buttons[2].SetActive(false);
    }
    private void Settings()
    {

    }
    //Om man trycker quit, st�ng spelet.
    private void QuitGame()
    {
        Application.Quit();
    }
}
