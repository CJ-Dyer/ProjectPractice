using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartInputField()
    {
        SceneManager.LoadScene("InputFieldScene");
    }

    public void StartSlider()
    {
        SceneManager.LoadScene("SliderScene");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void StartMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
