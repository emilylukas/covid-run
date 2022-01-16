using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string characterScene;

    public string sampleScene;

    public string musicScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame() {
        SceneManager.LoadScene(characterScene);
        // SceneManager.LoadScene(sampleScene);
        // SceneManager.LoadScene(musicScene);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
