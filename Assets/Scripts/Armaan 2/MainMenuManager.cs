using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public string nextscene;
  
    public void Play()
    {
        SceneManager.LoadScene(nextscene);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
