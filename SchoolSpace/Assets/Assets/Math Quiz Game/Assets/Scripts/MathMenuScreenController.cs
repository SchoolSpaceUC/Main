using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MathMenuScreenController : MonoBehaviour
{

    private void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}