using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour 
{
    static public GameObject description = null;
	private GameObject lastDescription = null;

	void Update () 
	{
        if (description != lastDescription && description != null)
        {
            description.SetActive(true);

            if (lastDescription != null)
                lastDescription.SetActive(false);
            
            lastDescription = description;
        }
	}

    public void LoadScene(string sceneToLoad)
    {
        Debug.Log("Click!");
        if (sceneToLoad != null)
            SceneManager.LoadScene(sceneToLoad);
        else
            Debug.LogError("sceneToLoad not specified");
    }



}
