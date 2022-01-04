using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Test()
    {
        //SceneManager.LoadScene(11);
        PlayerPrefs.SetInt("levelR", 11);
    }
    public void quit ()
    {
        Application.Quit();
    }
}

