using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour 
{
    public GameObject menuPanel;
    public GameObject aboutPanel;

    private void Awake()
    {
        if (menuPanel == null)
            Debug.LogError("menuPanel not specified");
        if (aboutPanel == null)
            Debug.LogError("äboutPanel not specified");
    }

    public void LoadScene (string sceneToLoad)
    {
        if (sceneToLoad != null)
            SceneManager.LoadScene(sceneToLoad);
        else
            Debug.LogError("sceneToLoad not specified");
    }

    public void OpenAboutPanel()
    {
        menuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void OpenMenuPanel()
    {
        aboutPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
}
