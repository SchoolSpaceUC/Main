using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Matching : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Matching");
    }
}