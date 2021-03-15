using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Matching");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}