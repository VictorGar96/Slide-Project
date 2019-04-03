using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);
        //Application.LoadLevel(name);
        
    }

    public void QuitRequest()
    {
        Debug.Log("Quit request");
        Application.Quit();
    }

    //Its going to load whatever is the next scene in the order of BuildSettings
    public void LoadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Application.LoadLevel(Application.loadedLevel + 1);

    }

    public void BacktoLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //Application.LoadLevel(Application.loadedLevel - 1);  

    }

}
