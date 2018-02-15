using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour 
{
    public string levelToLoad; // Level to load
    public float delayTime; // Delay time to load the level
	
	// Update is called once per frame
	void Update () 
    {
        // Call LoadLevel method after delayTime
        Invoke("LoadLevel", delayTime);
	}

    // Load Scene levelToLoad
    void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
