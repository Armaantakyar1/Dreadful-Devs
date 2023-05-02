using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] KeyCode player1InputA;
    [SerializeField] KeyCode player1InputB;
    [SerializeField] KeyCode player2InputA;
    [SerializeField] KeyCode player2InputB;
    public string nextscene;
    void Update()
    {
        if (Input.GetKeyDown(player1InputA) || Input.GetKeyDown(player2InputA))
        {
            NewScene();
        }
        if (Input.GetKeyDown(player1InputB) || Input.GetKeyDown(player2InputB))
        {
            QuitGame();
        }
    }
    void NewScene()
    {
        SceneManager.LoadScene(nextscene);
    }
    void QuitGame()
    {
        Application.Quit();
    }
}
