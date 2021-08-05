using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadPickSonger()
    {
        SceneManager.LoadScene("PickASongMenu");
    }

    public void QuitGame() {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void RecordPlay() {
        SceneManager.LoadScene("Recorder");
    }

    public void HowTo() {
        SceneManager.LoadScene("TutorialScene");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
