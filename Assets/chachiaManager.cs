using UnityEngine;

public class ChachiaManager : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject[] panels; // Assign the specific panels in the Inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMainPanel();
    }

    // Function to show the main panel and hide all other panels
    public void ShowMainPanel()
    {
        mainPanel.SetActive(true);
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }
 public void CloseMainPanel()
    {
        mainPanel.SetActive(false);
    }
    // Function to show a specific panel and hide the main panel
    public void ShowPanel(int panelIndex)
    {
        if (panelIndex >= 0 && panelIndex < panels.Length)
        {
            mainPanel.SetActive(false);
            panels[panelIndex].SetActive(true);
        }
    }

    // Function to hide a specific panel and show the main panel
    public void HidePanel(int panelIndex)
    {
        if (panelIndex >= 0 && panelIndex < panels.Length)
        {
            panels[panelIndex].SetActive(false);
            ShowMainPanel();
        }
    }
}