using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public GameObject creditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        creditsPanel.SetActive(false);
    }

    // Function to start the game
    public void StartGame()
    {
        // Load the main game scene (replace "MainScene" with your scene name)
        SceneManager.LoadScene("AR");
    }

    // Function to quit the game
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }

    // Function to open the credits panel
    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
    }

    // Function to go back from the credits panel
    public void BackFromCredits()
    {
        creditsPanel.SetActive(false);
    }
}