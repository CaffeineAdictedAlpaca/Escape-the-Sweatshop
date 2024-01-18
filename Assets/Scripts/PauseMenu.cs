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
    public Button MenuButton;
    public GameObject buttonsHolder;
    private void Start()
    { 
        // Kollar efter click på knapparna för att aktivera funktion - Adrian

        Button resume = ResumeButton.GetComponent<Button>();
        resume.onClick.AddListener(ResumeGame);

        Button settings = SettingsButton.GetComponent<Button>();
        settings.onClick.AddListener(Settings);

        Button mainmenu = MenuButton.GetComponent<Button>();
        mainmenu.onClick.AddListener(MainMenu);

        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitGame);
        //Gömmer knapparna från start
        buttonsHolder.SetActive(false);
    }
    void Update()
    {
        //Frys tiden och visa menyn om man trycker på escape
        if (Input.GetKeyDown("escape") && Time.timeScale == 1)
        {
            Time.timeScale = 0;
            buttonsHolder.SetActive(true);
        }
        //Om tiden är fryst göm knapparna och ofrys den om man trycker escape igen - Adrian
        else if (Input.GetKeyDown("escape") && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            buttonsHolder.SetActive(false);
        }
    }
    // Om man klickar resume, göm knapparna och resuma spelet - Adrian
    private void ResumeGame()
    {
        Time.timeScale = 1;
        buttonsHolder.SetActive(false);
    }
    private void Settings()
    {
        print("settings");
    }
    private void MainMenu()
    {
        SceneManager.UnloadSceneAsync("SampleScene");
    }

    //Om man trycker quit, stäng spelet.
    private void QuitGame()
    {
        Application.Quit();
    }
}
