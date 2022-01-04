using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    
    public Image _lock;

    public Button[] levelbuttons;
    // Start is called before the first frame update
    void Start()
    {
        
        int levelreached = PlayerPrefs.GetInt("levelR", 1);

        for (int i = 0; i < levelbuttons.Length; i++)
        {
            if (i + 1 > levelreached)
            {
                levelbuttons[i].interactable = false;
                
                levelbuttons[i].GetComponent<Button>().image = _lock;
            }
        }

        if (PlayerPrefs.GetInt("levelR") >= levelbuttons.Length)
        {
            PlayerPrefs.SetInt("levelR", levelbuttons.Length);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void Level(int level)
    {
        SceneManager.LoadScene(level);
    }
}
